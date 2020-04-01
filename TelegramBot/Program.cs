using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    class Program
    {
        private static readonly TelegramBotClient posBot = new TelegramBotClient("1125804301:AAE26ASXyTO0NgKWeRppknyfZIl6C1MTH18");
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
            DataForBot dataForBot = new DataForBot();

            if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
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
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Terrminal_PartnerTech.Photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: dataForBot.Terrminal_PartnerTech.inlineKeybord);
                        break;
                    case "/PAX900":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Terminal_PAX900.Photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: dataForBot.Terminal_PAX900.inlineKeybord);
                        break;
                    case "/POS":
                        string text_choose2 = "ընտրեք";
                        await posBot.SendTextMessageAsync(message.From.Id, text_choose2);
                        string text_POS = @"1./Verifone" + "\t" + "2./Ingenico";
                        await posBot.SendTextMessageAsync(message.From.Id, text_POS);
                        break;
                    case "/Verifone":
                        string text_choose3 = "ընտրեք";
                        await posBot.SendTextMessageAsync(message.From.Id, text_choose3);
                        string text_Verifone = @"1./vx520 " + "\t" + " 2./vx680";
                        await posBot.SendTextMessageAsync(message.From.Id, text_Verifone);
                        break;
                    case "/vx520":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Terminal_vx520.Photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: dataForBot.Terminal_vx520.inlineKeybord);
                        break;
                    case "/vx680":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Terminal_Vx680.Photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք գործարքը", replyMarkup: dataForBot.Terminal_Vx680.inlineKeybord);
                        break;
                    case "/Ingenico":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Terminal_Iwl250.Photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք գործարքը", replyMarkup: dataForBot.Terminal_Iwl250.inlineKeybord);
                        break;
                    case "/Contact": 
                        await posBot.SendTextMessageAsync(message.From.Id, dataForBot.Contacts.Get());
                        break;
                    case "/RespCode":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Link_respCode);
                        break;
                    case "/PaymentSystem":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Link_paymentSystem);
                        break;
                    case "/CardInfo":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Link_CardInfo);
                        break;
                    case "/CheckInfo":
                        await posBot.SendPhotoAsync(message.From.Id,dataForBot.Link_CheckInfo);
                        break;
                    case "/ChangeLink":
                        string text_choose4 = "input LINK";
                        await posBot.SendTextMessageAsync(message.From.Id, text_choose4);
                        dataForBot.Link_respCode = message.Text;
                        string text_choose5 = "succesfull";
                        await posBot.SendTextMessageAsync(message.From.Id, text_choose5);
                        break;
                    default:
                        break;
                }
                if (message.Text.Length >= 2 && message.Text.Length <= 3)
                {
                    string request = dataForBot.ResponseCodes.FindResponse(message.Text);
                    await posBot.SendTextMessageAsync(message.From.Id, request);
                }
            }
        }
    }
}
