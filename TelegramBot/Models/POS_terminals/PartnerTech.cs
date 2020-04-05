﻿using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public class PartnerTech
    {
        private string photo = @"https://photos.app.goo.gl/ptd6JjGbCGx9scQS7";
        public string Photo { get => photo; set => photo = value; }
        public PartnerTech(){ }
        public InlineKeyboardMarkup inlineKeybord = new InlineKeyboardMarkup(new[]
        {
            new[]{InlineKeyboardButton.WithUrl("վաճառք-Purchase","https://www.youtube.com/watch?v=FbaRBK1bsAU") },
            new[]{InlineKeyboardButton.WithUrl("անվավեր-Void","https://www.youtube.com/watch?v=FbaRBK1bsAU") },
            new[]{InlineKeyboardButton.WithUrl("հետվճար-Refund","https://www.youtube.com/watch?v=FbaRBK1bsAU") },
            new[]{InlineKeyboardButton.WithUrl("հավաստագրում-PrePurchase","https://www.youtube.com/watch?v=FbaRBK1bsAU") },
            new[]{InlineKeyboardButton.WithUrl("հաստատում-Complete(PrePurchase)","https://www.youtube.com/watch?v=FbaRBK1bsAU") }
        });
    }
}