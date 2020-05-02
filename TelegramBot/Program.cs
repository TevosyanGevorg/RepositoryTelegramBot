using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace TelegramBot
{
    class Program
    {
        private static readonly TelegramBotClient posBot = new TelegramBotClient("1125804301:AAGqeQcWqxtkrcXona1UgnH3ulXuBpoujXQ");
        static void Main(string[] args)
        {
            // HOW CAN I CHANGE THIS CODE FOR SERVER/ OR SERVICE
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
            string message1 = "/" + e.Message.Text;
            DataForBot dataForBot = new DataForBot();

            if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                switch (message1)
                {
                    case "//start":
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք", replyMarkup: dataForBot.GeneralMenu);
                        break;
                    case "/Գլխավոր մենյու":
                        await posBot.SendTextMessageAsync(message.Chat.Id, "ընտրեք", replyMarkup: dataForBot.GeneralMenu);
                        break;
                    case "/Սարքեր":
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք", replyMarkup: dataForBot.SecondMenu);
                        break;
                    case "/ՀԴՄ PartnerTech":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Terrminal_PartnerTech.Photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: dataForBot.Terrminal_PartnerTech.inlineKeybord);
                        break;
                    case "/ՀԴՄ PAX900":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Terminal_PAX900.Photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: dataForBot.Terminal_PAX900.inlineKeybord);
                        break;
                    case "/Verifone vx520 և vx680":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Terminal_Vx680.Photo);
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Terminal_vx520.Photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: dataForBot.Terminal_vx520.inlineKeybord);
                        break;
                    case "/Ingenico iWL250":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Terminal_Iwl250.Photo);
                        await posBot.SendTextMessageAsync(message.From.Id, "ընտրեք գործարքը", replyMarkup: dataForBot.Terminal_Iwl250.inlineKeybord);
                        break;
                    case "/Հեռախոսահամարներ": 
                        await posBot.SendTextMessageAsync(message.From.Id, dataForBot.Contacts.Get());
                        break;
                    case "/Մերժման կոդերի աղյուսակ":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Link_respCode);
                        break;
                    case "/Գանձապահի ուսուցում":
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Link_paymentSystem);
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Link_CardInfo);
                        await posBot.SendPhotoAsync(message.From.Id, dataForBot.Link_CheckInfo);
                        break;
 //------------------------------------------------------ HOW TO DO IT ---------------------------------------------------------------
                    case "/ChangeLink":
                        string text_choose4 = "input LINK";
                        await posBot.SendTextMessageAsync(message.From.Id, text_choose4);
                        dataForBot.Link_respCode = message.Text;
                        string text_choose5 = "succesfull";
                        await posBot.SendTextMessageAsync(message.From.Id, text_choose5);
                        break;
 //-----------------------------------------------------------------------------------------------------------------------------------

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
