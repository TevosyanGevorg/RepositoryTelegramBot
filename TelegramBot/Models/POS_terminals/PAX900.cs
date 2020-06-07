using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public class PAX900
    {
        private string photo = @"https://lh3.googleusercontent.com/pw/ACtC-3cpMTzu9bF0afjPiuRWk53cnF5L4AlAfJP55gLJhbORNnOKdPKc-wcoJqO2YaL_Rjupncr27nQdki5Ib2PqTq9TCIMdy_RTPNtSAcIXmuPDYVjtWzxcpHFXXr7JBKp4Fm89RYD7QMT5LGmYOgfp10nV=s225-no?authuser=0";
        public string Photo { get => photo; set => photo = value; }
        public PAX900(){ }
        public InlineKeyboardMarkup inlineKeybord = new InlineKeyboardMarkup(new[]
        {
            new[]{InlineKeyboardButton.WithUrl("վաճառք-Purchase","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE") },
            new[]{InlineKeyboardButton.WithUrl("անվավեր-Void","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE") },
            new[]{ InlineKeyboardButton.WithUrl("հետվճար-Refund","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE")},
            new[]{InlineKeyboardButton.WithUrl("հավաստագրում-PrePurchase","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE") },
            new[]{InlineKeyboardButton.WithUrl("հաստատում-Complete(PrePurchase)","https://www.youtube.com/watch?v=Ky7qfsU8Oak&list=PL4bL2ez_ahhCazgiaj7MF7kntFNKqPhyE") }
        });
    }
}
