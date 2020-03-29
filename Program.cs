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

namespace TelegramBot
{
    class Program
    {
        private static readonly TelegramBotClient posBot = new TelegramBotClient("1125804301:AAEmJ1zaFOz9lq7SltvAl35h1jI2WLs44Uo");
        static void Main(string[] args)
        {
            posBot.OnMessage += BotOnMessageReceived;
            //posBot.OnCallbackQuery += BotOnCallbackQueryReceived;
            var me = posBot.GetMeAsync().Result;
            Console.Title = me.Username;
            posBot.StartReceiving();
            Console.ReadLine();
            posBot.StopReceiving();
        }

        //private static void BotOnCallbackQueryReceived(object sender, CallbackQueryEventArgs e)
        //{
        //}

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
                        string file_Partner = @"https://photos.app.goo.gl/ptd6JjGbCGx9scQS7";
                        await posBot.SendPhotoAsync(message.From.Id, file_Partner);

                        var inlineKeybord_transaction = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("Purchase-վաճառք","https://www.youtube.com/watch?v=FbaRBK1bsAU"),
                                InlineKeyboardButton.WithUrl("Void-անվավեր","https://www.youtube.com/watch?v=FbaRBK1bsAU"),
                                InlineKeyboardButton.WithUrl("Refund-հետվճար","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("PrePurchase-հավաստագրում","https://www.youtube.com/watch?v=FbaRBK1bsAU"),
                                InlineKeyboardButton.WithUrl("Complete(PrePurchase)-հաստատում","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            }
                        });
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք գործարքը", replyMarkup: inlineKeybord_transaction);

                        var inlineKeybord_settings = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("DuplicateCheck-կրկնօրինակ","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("RemoveReversal-մաքրել ավտոանվավերը","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("Settlement-փաթեթի ուղարկում","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            }
                        });
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: inlineKeybord_settings);
                        break;

                    case "/PAX900":
                        string file_PAX900 = @"https://photos.app.goo.gl/Dd4ZpjjAhRUuT3Hr6";
                        await posBot.SendPhotoAsync(message.From.Id, file_PAX900);
                        var inlineKeybord_PAX900 = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("Purchase-վաճառք","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE"),
                                InlineKeyboardButton.WithUrl("Void-անվավեր","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE"),
                                InlineKeyboardButton.WithUrl("Refund-հետվճար","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("PrePurchase-հավաստագրում","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE"),
                                InlineKeyboardButton.WithUrl("Complete(PrePurchase)-հաստատում","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE")
                            }
                        });
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք գործարքը", replyMarkup: inlineKeybord_PAX900);
                        var inlineKeybord_settings_PAX900 = new InlineKeyboardMarkup(new[]
{
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("DuplicateCheck-կրկնօրինակ","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("RemoveReversal-մաքրել ավտոանվավերը","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("Settlement-փաթեթի ուղարկում","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            }
                        });
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: inlineKeybord_settings_PAX900);
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
                        string file_vx520 = @"https://photos.app.goo.gl/BHb1Kqcrfu3wcrKn6";
                        await posBot.SendPhotoAsync(message.From.Id, file_vx520);
                        var inlineKeybord_vx520 = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("Purchase-վաճառք","https://www.youtube.com/watch?v=JKLhe3pJBi8"),
                                InlineKeyboardButton.WithUrl("Void-անվավեր","https://www.youtube.com/watch?v=JKLhe3pJBi8"),
                                InlineKeyboardButton.WithUrl("Refund-հետվճար","https://www.youtube.com/watch?v=JKLhe3pJBi8")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("PrePurchase-հավաստագրում","https://www.youtube.com/watch?v=JKLhe3pJBi8"),
                                InlineKeyboardButton.WithUrl("Complete(PrePurchase)-հաստատում","https://www.youtube.com/watch?v=JKLhe3pJBi8")
                            }
                        });
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք գործարքը", replyMarkup: inlineKeybord_vx520);
                        var inlineKeybord_settings_vx520 = new InlineKeyboardMarkup(new[]
{
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("DuplicateCheck-կրկնօրինակ","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("RemoveReversal-մաքրել ավտոանվավերը","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("Settlement-փաթեթի ուղարկում","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("TerminalBlocked-Տերմինալի բլոկավորում","https://www.youtube.com/watch?v=FbaRBK1bsAU"),
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("CheackConnection-Կապի Ստուգում","https://www.youtube.com/watch?v=FbaRBK1bsAU"),
                            }
                        });
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: inlineKeybord_settings_vx520);
                        break;

                    case "/vx680":
                        string file_vx680 = @"https://photos.app.goo.gl/URvLRtWGqAD2V4DRA";
                        await posBot.SendPhotoAsync(message.From.Id, file_vx680);
                        var inlineKeybord_vx680 = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("Purchase-վաճառք","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s"),
                                InlineKeyboardButton.WithUrl("Void-անվավեր","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s"),
                                InlineKeyboardButton.WithUrl("Refund-հետվճար","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("PrePurchase-հավաստագրում","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s"),
                                InlineKeyboardButton.WithUrl("Complete(PrePurchase)-հաստատում","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s")
                            }
                        });
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք գործարքը", replyMarkup: inlineKeybord_vx680);
                        var inlineKeybord_settings_vx680 = new InlineKeyboardMarkup(new[]
{
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("DuplicateCheck-կրկնօրինակ","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("RemoveReversal-մաքրել ավտոանվավերը","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("Settlement-փաթեթի ուղարկում","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("TerminalBlocked-Տերմինալի բլոկավորում","https://www.youtube.com/watch?v=FbaRBK1bsAU"),
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("CheackConnection-Կապի Ստուգում","https://www.youtube.com/watch?v=FbaRBK1bsAU"),
                            }
                        });
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: inlineKeybord_settings_vx680);
                        break;

                    case "/Ingenico":
                        string file_Ingenico = @"https://photos.app.goo.gl/xsZkAZfp2VmwtfqRA";
                        await posBot.SendPhotoAsync(message.From.Id, file_Ingenico);
                        var inlineKeybord_Ingenico = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("Purchase-վաճառք","https://www.youtube.com/watch?v=L9VNSvJkM5w"),
                                InlineKeyboardButton.WithUrl("Void-անվավեր","https://www.youtube.com/watch?v=L9VNSvJkM5w"),
                                InlineKeyboardButton.WithUrl("Refund-հետվճար","https://www.youtube.com/watch?v=L9VNSvJkM5w")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("PrePurchase-հավաստագրում","https://www.youtube.com/watch?v=L9VNSvJkM5w"),
                                InlineKeyboardButton.WithUrl("Complete(PrePurchase)-հաստատում","https://www.youtube.com/watch?v=L9VNSvJkM5w")
                            }
                        });
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք գործարքը", replyMarkup: inlineKeybord_Ingenico);
                        var inlineKeybord_settings_Ingenico = new InlineKeyboardMarkup(new[]
{
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("DuplicateCheck-կրկնօրինակ","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("RemoveReversal-մաքրել ավտոանվավերը","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("Settlement-փաթեթի ուղարկում","https://www.youtube.com/watch?v=FbaRBK1bsAU")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithUrl("CheackConnection-Կապի Ստուգում","https://www.youtube.com/watch?v=FbaRBK1bsAU"),
                            }
                        });
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: inlineKeybord_settings_Ingenico);
                        break;

                    case "/start":
                        var rekplyKeyboard = new ReplyKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                new KeyboardButton("/choosePOS"),
                                new KeyboardButton("/Contact")
                            },
                            new[]
                            {
                                new KeyboardButton("/RespCode"),
                                new KeyboardButton("/CheckInfo")
                            },
                            new[]
                            {
                                new KeyboardButton("/PaymentSystem"),
                                new KeyboardButton("/CardInfo")
                            },
                        });
                        await posBot.SendTextMessageAsync(message.Chat.Id, "Բարև Ձեզ", replyMarkup: rekplyKeyboard);
                        break;

                    case "/Contact":
                        string text_Contact1 = "\n098171845 Գևորգ" + "\n098171846 Վաղինակ" + "\n098171847 Արամ" + "\n099560515 Միքաել" + "\n043001067 Էդուարդ" + "\n043001068 Ալբերտ";
                        string text_Contact2 = "\nոչ աշխատանքային ժամերին`" + "\n010561111";
                        await posBot.SendTextMessageAsync(message.From.Id, text_Contact1 + text_Contact2);
                        break;

                    case "/RespCode":
                        string file_RespCode = @"https://photos.app.goo.gl/pA9LAuwBp7SCp7dD7";
                        await posBot.SendPhotoAsync(message.From.Id, file_RespCode);
                        break;

                    case "/PaymentSystem":
                        string file_PaymentSystem5 = @"https://photos.app.goo.gl/EqnAyq7dceNC7Va68";
                        await posBot.SendPhotoAsync(message.From.Id, file_PaymentSystem5);
                        break;

                    case "/CardInfo":
                        string file_CardInfo = @"https://photos.app.goo.gl/THHKS3k2ZYuiFeCCA";
                        await posBot.SendPhotoAsync(message.From.Id, file_CardInfo);
                        break;

                    case "/CheckInfo":
                        string file_ReceiptInfo = @"https://photos.app.goo.gl/FMNJRyFVkHALFWJH8";
                        await posBot.SendPhotoAsync(message.From.Id, file_ReceiptInfo);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
