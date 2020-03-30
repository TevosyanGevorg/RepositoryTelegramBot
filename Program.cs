using System;
using Microsoft.VisualBasic.CompilerServices;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;
using System.Text;
using System.IO;
using System.Collections.Generic;
using Telegram.Bot.Types.InlineQueryResults;
using TelegramBot.TelegramBot;

namespace TelegramBot
{
    class Program
    {
        private static readonly TelegramBotClient posBot = new TelegramBotClient("1125804301:AAEmJ1zaFOz9lq7SltvAl35h1jI2WLs44Uo");
        static void Main(string[] args)
        {
            posBot.OnMessage += BotOnMessageReceived;
            var me = posBot.GetMeAsync().Result;
            Console.Title = me.Username;
            posBot.StartReceiving();
            Console.ReadLine();
            posBot.StopReceiving();
        }

        private static async void BotOnMessageReceived(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            if (message == null || message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
                return;
            if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                if (message.Text.Length >= 2 && message.Text.Length <= 3)
                {
                    RespCodes respcodes = new RespCodes();
                    string request = respcodes.GetRespCode(message.Text);
                    await posBot.SendTextMessageAsync(message.From.Id, request);
                }

                switch (message.Text)
                {
                    case "/start":
                        var rekplyKeyboard = new ReplyKeyboardMarkup(new[]
                        {
                            new[]{new KeyboardButton("/choosePOS"),new KeyboardButton("/Contact")},
                            new[]{new KeyboardButton("/RespCode"),new KeyboardButton("/CheckInfo")},
                            new[]{new KeyboardButton("/PaymentSystem"),new KeyboardButton("/CardInfo")}
                        });
                        await posBot.SendTextMessageAsync(message.Chat.Id, "Բարև Ձեզ", replyMarkup: rekplyKeyboard);
                        break;
                    case "/choosePOS":
                        string text_choose = "ընտրեք";
                        await posBot.SendTextMessageAsync(message.From.Id, text_choose);
                        string text_start = @"1./POS" + "\t" + "\t" + "2./HDM(POS)";
                        await posBot.SendTextMessageAsync(message.From.Id, text_start);
                        break;
                    case "/HDM":
                        string text_choose1 = "ընտրեք";
                        await posBot.SendTextMessageAsync(message.From.Id, text_choose1);
                        string text_HDM = @"1./PartnerTech" + "\t" + "2./PAX900";
                        await posBot.SendTextMessageAsync(message.From.Id, text_HDM);
                        break;
                    case "/PartnerTech":
                        PartnerTech terrminalPartnerTech = new PartnerTech();
                        await posBot.SendPhotoAsync(message.From.Id, terrminalPartnerTech.photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: terrminalPartnerTech.inlineKeybord);
                        break;
                    case "/PAX900":
                        PAX900 terminalPAX900 = new PAX900();
                        await posBot.SendPhotoAsync(message.From.Id, terminalPAX900.photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: terminalPAX900.inlineKeybord);
                        break;
                    case "/POS":
                        string text_choose3 = "ընտրեք";
                        await posBot.SendTextMessageAsync(message.From.Id, text_choose3);
                        string text_POS = @"1./Verifone" + "\t" + "2./Ingenico";
                        await posBot.SendTextMessageAsync(message.From.Id, text_POS);
                        break;
                    case "/Verifone":
                        string text_choose4 = "ընտրեք";
                        await posBot.SendTextMessageAsync(message.From.Id, text_choose4);
                        string text_Verifone = @"1./vx520 " + "\t" + " 2./vx680";
                        await posBot.SendTextMessageAsync(message.From.Id, text_Verifone);
                        break;
                    case "/vx520":
                        Vx520 terminalvx520= new Vx520();
                        await posBot.SendPhotoAsync(message.From.Id, terminalvx520.photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: terminalvx520.inlineKeybord);
                        break;
                    case "/vx680":
                        Vx680 terminalVx680 = new Vx680();
                        await posBot.SendPhotoAsync(message.From.Id, terminalVx680.photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք գործարքը", replyMarkup: terminalVx680.inlineKeybord);
                        break;
                    case "/Ingenico":
                        Iwl250 terminalIwl250 = new Iwl250();
                        await posBot.SendPhotoAsync(message.From.Id, terminalIwl250.photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք գործարքը", replyMarkup: terminalIwl250.inlineKeybord);
                        break;
                    case "/Contact":
                        string text_Contact1 = "\n098171845 Գևորգ" + "\n098171846 Վաղինակ" + "\n098171847 Արամ" + "\n099560515 Միքաել" + "\n043001067 Էդուարդ" + "\n043001068 Ալբերտ";
                        string text_Contact2 = "\nոչ աշխատանքային ժամերին`" + "\n010561111";
                        await posBot.SendTextMessageAsync(message.From.Id, text_Contact1 + text_Contact2);
                        break;
                    case "/RespCode":
                        string file_RespCode = @"https://photos.app.goo.gl/XBXPeFDNpJ1DgGD56";
                        await posBot.SendTextMessageAsync(message.From.Id, file_RespCode);
                        break;
                    case "/PaymentSystem":
                        string file_PaymentSystem5 = @"https://photos.app.goo.gl/zzztH17mLFNxUjCj6";
                        await posBot.SendTextMessageAsync(message.From.Id, file_PaymentSystem5);
                        break;
                    case "/CardInfo":
                        string file_CardInfo = @"https://photos.app.goo.gl/CTccm5mWvUfXXcaE6";
                        await posBot.SendTextMessageAsync(message.From.Id, file_CardInfo);
                        break;
                    case "/CheckInfo":
                        string file_ReceiptInfo = @"https://photos.app.goo.gl/WthVSsxcDhGpXnNcA";
                        await posBot.SendTextMessageAsync(message.From.Id, file_ReceiptInfo);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
