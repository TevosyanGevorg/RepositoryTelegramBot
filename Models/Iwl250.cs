using System;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public class Iwl250
    {
        public string photo = @"https://photos.app.goo.gl/xsZkAZfp2VmwtfqRA";

        public Iwl250()
        {
        }

        public InlineKeyboardMarkup inlineKeybord = new InlineKeyboardMarkup(new[]
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
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("կրկնօրինակ-DuplicateCheck","https://www.youtube.com/watch?v=L9VNSvJkM5w")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("մաքրել ավտոանվավերը-RemoveReversal","https://www.youtube.com/watch?v=L9VNSvJkM5w")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("փաթեթի ուղարկում-Settlement","https://www.youtube.com/watch?v=L9VNSvJkM5w")
            }
        });




    }
}
