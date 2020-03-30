using System;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public class Vx680
    {
        public string photo = @"https://photos.app.goo.gl/URvLRtWGqAD2V4DRA";

        public Vx680()
        {
        }

        public InlineKeyboardMarkup inlineKeybord = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithUrl("վաճառք-Purchase","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s"),
                InlineKeyboardButton.WithUrl("անվավեր-Void","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s"),
                InlineKeyboardButton.WithUrl("հետվճար-Refund","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("հավաստագրում-PrePurchase","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s"),
                InlineKeyboardButton.WithUrl("հաստատում-Complete(PrePurchase)","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("կրկնօրինակ-DuplicateCheck","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("մաքրել ավտոանվավերը-RemoveReversal","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("փաթեթի ուղարկում-Settlement","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s")
            }
        });




    }
}
