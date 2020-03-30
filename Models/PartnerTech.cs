using System;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public class PartnerTech
    {
        public string photo = @"https://photos.app.goo.gl/ptd6JjGbCGx9scQS7";

        public PartnerTech()
        {
        }

        public InlineKeyboardMarkup inlineKeybord = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithUrl("վաճառք-Purchase","https://www.youtube.com/watch?v=FbaRBK1bsAU"),
                InlineKeyboardButton.WithUrl("անվավեր-Void","https://www.youtube.com/watch?v=FbaRBK1bsAU"),
                InlineKeyboardButton.WithUrl("հետվճար-Refund","https://www.youtube.com/watch?v=FbaRBK1bsAU")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("հավաստագրում-PrePurchase","https://www.youtube.com/watch?v=FbaRBK1bsAU"),
                InlineKeyboardButton.WithUrl("հաստատում-Complete(PrePurchase)","https://www.youtube.com/watch?v=FbaRBK1bsAU")
            },
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



    }
}
