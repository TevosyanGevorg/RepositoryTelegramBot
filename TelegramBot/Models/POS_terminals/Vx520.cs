using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public class Vx520
    {
        private string photo = @"https://lh3.googleusercontent.com/pw/ACtC-3c29SaZhFrMntAd__bhnKU5Sf2xiFainfCQXzYvU9C31pWPxfhFE7tFEjjLsxPMrsfpWa579tPSmWkv1XFlkVqCUr6J8rX0pVI4hE2fOzzOmwuWOOf6lQk_uTdtlujxzE3MphP0FtTEya1M07_CA3Yl=s225-no?authuser=0";
        public string Photo { get => photo; set => photo = value; }
        public Vx520() { }
        public InlineKeyboardMarkup inlineKeybord = new InlineKeyboardMarkup(new[]
        {
            new[]{InlineKeyboardButton.WithUrl("վաճառք-Purchase","https://www.youtube.com/watch?v=JKLhe3pJBi8") },
            new[]{InlineKeyboardButton.WithUrl("անվավեր-Void","https://www.youtube.com/watch?v=JKLhe3pJBi8") },
            new[]{InlineKeyboardButton.WithUrl("հետվճար-Refund","https://www.youtube.com/watch?v=JKLhe3pJBi8") },
            new[]{InlineKeyboardButton.WithUrl("հավաստագրում-PrePurchase","https://www.youtube.com/watch?v=JKLhe3pJBi8") },
            new[]{InlineKeyboardButton.WithUrl("հաստատում-Complete(PrePurchase)","https://www.youtube.com/watch?v=JKLhe3pJBi8") }
        });
    }
}
