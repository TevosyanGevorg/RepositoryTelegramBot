using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public class PartnerTech
    {
        private string photo = @"https://lh3.googleusercontent.com/pw/ACtC-3dKFQuhAq_c9pGtHmwVVUY4Hz4nnJkcADzelNa0HsGDasQVFRW8B883iTO0jnZc5mxCOXUJGdf98SeFHJGb24NptFcYhqqs8DWztdf6J01GTD9NRm-956YxizjxZwFr0RQ-Nou4dMXhFLoNQE4x8mOQ=s225-no?authuser=0";
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
