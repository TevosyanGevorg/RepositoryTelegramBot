using System;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot.TelegramBot
{
    public class Vx680
    {
        public string nameOfPosTerminal = "/vx680";
        public string URl_photo = @"https://photos.app.goo.gl/URvLRtWGqAD2V4DRA";
        public Vx680()
        {

        }

       public InlineKeyboardMarkup inlineKeybord_vx680 = new InlineKeyboardMarkup(new[]
       {
            new[]
            {
                InlineKeyboardButton.WithUrl("վաճառք-Purchase","https://www.youtube.com/watch?v=L9VNSvJkM5w"),
                InlineKeyboardButton.WithUrl("անվավեր-Void","https://www.youtube.com/watch?v=L9VNSvJkM5w"),
                InlineKeyboardButton.WithUrl("հետվճար-Refund","https://www.youtube.com/watch?v=L9VNSvJkM5w")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("հավաստագրում-PrePurchase","https://www.youtube.com/watch?v=L9VNSvJkM5w"),
                InlineKeyboardButton.WithUrl("հաստատում-Complete(PrePurchase)","https://www.youtube.com/watch?v=L9VNSvJkM5w")
            }
        });
        public InlineKeyboardMarkup inlineKeybord_settings_vx680 = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithUrl("կրկնօրինակ-DuplicateCheck","https://www.youtube.com/watch?v=FbaRBK1bsAU")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("մաքրել ավտոանվավերը-RemoveReversal","https://www.youtube.com/watch?v=FbaRBK1bsAU")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("փաթեթի ուղարկում-Settlement","https://www.youtube.com/watch?v=FbaRBK1bsAU")
            }
        });

        //public enum TypeTrancaction
        //{
        //    Purchase,
        //    Void,
        //    Refund,
        //    PrePurchase,
        //    Complete,
        //    DuplicateCheck,
        //    RemoveReversal,
        //    Settlement
        //}
        //static InlineKeyboardButton URL_Video_Purchase ;
        //static InlineKeyboardButton URL_Video_Void;
        //static InlineKeyboardButton URL_Video_Refund ;
        //static InlineKeyboardButton URL_Video_PrePurchase;
        //static InlineKeyboardButton URL_Video_Complete;
        //static InlineKeyboardButton URL_Video_DuplicateCheck;
        //static InlineKeyboardButton URL_Video_RemoveReversal;
        //static InlineKeyboardButton URL_Video_Settlement;
        //public InlineKeyboardMarkup inlineKeybord_vx680 = new InlineKeyboardMarkup(new[]
        //{
        //    new[]
        //    {
        //        URL_Video_Purchase,
        //        URL_Video_Void,
        //        URL_Video_Refund
        //    },
        //    new[]
        //    {
        //        URL_Video_PrePurchase,
        //        URL_Video_Complete
        //    },
        //    new[]
        //    {
        //        URL_Video_DuplicateCheck,
        //        URL_Video_RemoveReversal,
        //        URL_Video_Settlement
        //    }
        //});
        //public string SetURL(TypeTrancaction transaction, string VideoURL_Purchase)
        //{
        //    string typeTrancaction = "N/A";
        //    switch (transaction)
        //    {
        //        case TypeTrancaction.Purchase:
        //            typeTrancaction = "վաճառք - Purchase";
        //            URL_Video_Purchase= InlineKeyboardButton.WithUrl(typeTrancaction, VideoURL_Purchase);
        //            break;
        //        case TypeTrancaction.Void:
        //            typeTrancaction = "անվավեր-Void";
        //            URL_Video_Void= InlineKeyboardButton.WithUrl(typeTrancaction, VideoURL_Purchase);
        //            break;
        //        case TypeTrancaction.Refund:
        //            typeTrancaction = "հետվճար-Refund";
        //            URL_Video_Refund=InlineKeyboardButton.WithUrl(typeTrancaction, VideoURL_Purchase);
        //            break;
        //        case TypeTrancaction.PrePurchase:
        //            typeTrancaction = "հավաստագրում-PrePurchase";
        //            URL_Video_PrePurchase = InlineKeyboardButton.WithUrl(typeTrancaction, VideoURL_Purchase);
        //            break;
        //        case TypeTrancaction.Complete:
        //            typeTrancaction = "հաստատում-Complete(PrePurchase)";
        //            URL_Video_Complete =InlineKeyboardButton.WithUrl(typeTrancaction, VideoURL_Purchase);
        //            break;
        //        case TypeTrancaction.DuplicateCheck:
        //            typeTrancaction = "կրկնօրինակ-DuplicateCheck";
        //            URL_Video_DuplicateCheck =InlineKeyboardButton.WithUrl(typeTrancaction, VideoURL_Purchase);
        //            break;
        //        case TypeTrancaction.RemoveReversal:
        //            typeTrancaction = "մաքրել ավտոանվավերը-RemoveReversal";
        //            URL_Video_RemoveReversal = InlineKeyboardButton.WithUrl(typeTrancaction, VideoURL_Purchase);
        //            break;
        //        case TypeTrancaction.Settlement:
        //            typeTrancaction = "փաթեթի ուղարկում-Settlement";
        //            URL_Video_Settlement = InlineKeyboardButton.WithUrl(typeTrancaction, VideoURL_Purchase);
        //            break;
        //        default:
        //            break;
        //    }
        //    return typeTrancaction;
        //}
    }
}
