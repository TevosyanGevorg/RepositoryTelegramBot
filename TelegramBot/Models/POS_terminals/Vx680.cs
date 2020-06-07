using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public class Vx680
    {
        private string photo = @"https://lh3.googleusercontent.com/pw/ACtC-3dLLGFGwFniqMc0cuF2pNP-yYkec3PzCy4thMSxzB9bcXl65giVYmUsxy1lar27i5UynLN5WSofjNvyKaVuKoPkMYE42LOw5PtozobrRkSPUb0i6qODkKmeq52aPNppuwzRvdpB1lVmtIdfGr1U3w2R=s225-no?authuser=0";
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
