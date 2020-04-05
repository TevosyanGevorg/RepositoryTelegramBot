using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public class Vx520
    {
        private string photo = @"https://photos.app.goo.gl/BHb1Kqcrfu3wcrKn6";
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
