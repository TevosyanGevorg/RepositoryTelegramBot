﻿using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public class Vx680
    {
        private string photo = @"https://photos.app.goo.gl/URvLRtWGqAD2V4DRA";
        public string Photo { get => photo; set => photo = value; }
        public Vx680() { }
        public InlineKeyboardMarkup inlineKeybord = new InlineKeyboardMarkup(new[]
        {
            new[]{InlineKeyboardButton.WithUrl("վաճառք-Purchase","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s") },
            new[]{InlineKeyboardButton.WithUrl("անվավեր-Void","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s") },
            new[]{InlineKeyboardButton.WithUrl("հետվճար-Refund","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s")},
            new[]{InlineKeyboardButton.WithUrl("հավաստագրում-PrePurchase","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s") },
            new[]{InlineKeyboardButton.WithUrl("հաստատում-Complete(PrePurchase)","https://www.youtube.com/watch?v=mDm7U16cxNA&t=291s")}
        });
    }
}