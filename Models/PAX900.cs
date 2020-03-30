using System;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public class PAX900
    {
        public string photo = @"https://photos.app.goo.gl/Dd4ZpjjAhRUuT3Hr6";

        public PAX900()
        {
        }
        public InlineKeyboardMarkup inlineKeybord = new InlineKeyboardMarkup(new[]
{
            new[]
            {
                InlineKeyboardButton.WithUrl("վաճառք-Purchase","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE"),
                InlineKeyboardButton.WithUrl("անվավեր-Void","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE"),
                InlineKeyboardButton.WithUrl("հետվճար-Refund","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("հավաստագրում-PrePurchase","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE"),
                InlineKeyboardButton.WithUrl("հաստատում-Complete(PrePurchase)","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("կրկնօրինակ-DuplicateCheck","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("մաքրել ավտոանվավերը-RemoveReversal","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE")
            },
            new[]
            {
                InlineKeyboardButton.WithUrl("փաթեթի ուղարկում-Settlement","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE")
            }
        });
    }
}
