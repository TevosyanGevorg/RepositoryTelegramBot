using Telegram.Bot.Types.ReplyMarkups;
using TelegramBot.Models;

namespace TelegramBot
{
    public class DataForBot
    {
        private string link_respCode;
        private string link_paymentSystem;
        private string link_CardInfo;
        private string link_CheckInfo;
        private Vx680 terminal_Vx680;
        private Iwl250 terminal_Iwl250;
        private Vx520 terminal_vx520;
        private PAX900 terminal_PAX900;
        private PartnerTech terrminal_PartnerTech;
        private RespCodes responseCodes;
        private Contacts contacts;
        private ReplyKeyboardMarkup menu_general;
        private ReplyKeyboardMarkup menu_second;
        private ReplyKeyboardMarkup menu_Iwl250;
        private ReplyKeyboardMarkup menu_PAX900;
        private ReplyKeyboardMarkup menu_PartnerTech;

        public string Link_respCode { get => link_respCode; set => link_respCode = value; }
        public string Link_paymentSystem { get => link_paymentSystem; set => link_paymentSystem = value; }
        public string Link_CardInfo { get => link_CardInfo; set => link_CardInfo = value; }
        public string Link_CheckInfo { get => link_CheckInfo; set => link_CheckInfo = value; }
        public Vx680 Terminal_Vx680 { get => terminal_Vx680; set => terminal_Vx680 = value; }
        public Iwl250 Terminal_Iwl250 { get => terminal_Iwl250; set => terminal_Iwl250 = value; }
        public Vx520 Terminal_vx520 { get => terminal_vx520; set => terminal_vx520 = value; }
        public PAX900 Terminal_PAX900 { get => terminal_PAX900; set => terminal_PAX900 = value; }
        public PartnerTech Terrminal_PartnerTech { get => terrminal_PartnerTech; set => terrminal_PartnerTech = value; }
        public RespCodes ResponseCodes { get => responseCodes; set => responseCodes = value; }
        public Contacts Contacts { get => contacts; set => contacts = value; }
        public ReplyKeyboardMarkup Menu_General { get => menu_general; set => menu_general = value; }
        public ReplyKeyboardMarkup Menu_Second { get => menu_second; set => menu_second = value; }
        public DataForBot()
        {
            Link_respCode = @"https://lh3.googleusercontent.com/VqiIxmxtZWnM-eZKo9-fQmAvqknhbnWQivxKH0enQZxhFFB0IGY32dmMPG73puk9Z0tjiQM399cHYujH3BmDv2V09VvY_o_RQYb0QBJVWcLmFt-hOYovCOEf3tCjju2rlywGP85ORtvggI4ODHZ6MVkHiwmAUnR-Co8z-zjr5rwRG1RFoYQo9HI1TJrtlDdm_R1dPJD3XM5E5A4Zt_H8H_ICbRBZRDeywKQXhV10XVt9qYoLzEFWzjh69767UxrJWHzeXlsXLc6-ysiVwjutYP8NmdD1syGpifxmFKsb9arJjvhM1R513hLom84YtIxWIBO67VgOVwr1A6cUCJoIPST3_jSNZYnFR91nZ5K4a8zWlyhFsaUGwIS7KpwqEqthcalvn8bu7MxRRjY7p6J-VYdm1F-GFHAFpFeLZZP48ZOOSk0c_PnE-nfmlncI67HS7OAjD1-MOEy65bWmr9ByslZPwX2MEd98HKfMrNL8UllrR1k7r3OSTmylBil55FKwXSqa-4JaMdavOCbF9NBafRPoqHsNYSSyNVuwyz-HygiK6EkaCI3VTCuQqZm4S8-ni_8R7OAAg9Mvso0bIDA_RlsgBUKkmtTMF1QIfhOpNQNNJerWvpeFv4qHKnTMVIlwP-y2l1CVJZUZL0FWa7VBNghRO3oMFnfeQ9lBtJPjwfkyNWtmh9YGlMGgCbEdOUabds4tpUYinvse1_KHrm7CB5RpT04h60O0uVHXaMw9zu7Ob0kPpZ81Gg=w1000-h1414-no";
            Link_paymentSystem = @"https://lh3.googleusercontent.com/nVSGi67meMkUa1bw28bExJ6-BOcrbNHDkEcgzAGE4CB220wpUk5at8YDQ1-dkFYKxYeNh_-_GlaBOXJ-vjWumyHKVoNT7a38T9CSJh0iHO8t2_sBtCreQjyOGj2QooG3IedO10ITX6cRVIcCwhnb3Ea2lTLiFsMwLPJaytxvR4QnEzl0pgAOjeGZHt_Q8f9PjiwNUhW6kNMBsQgy5OMuo7NZQTR9_UQfRsduqwFzCEN-Q_A0L23yQTl8yI74ge7-C8PwpltQFjcxU4Ihx7rhiXgR5todn2SzUINogj8SLXYIfunUS9Ojn2U9Pza61rlNI3662BVuHNHuusCMKMdfbLn7olHM8b8U_YgqbNdC5T58cp-0cQihpEDj1vWIst5a1CYD1M5btSWJtHTekHeeP_oNERvieJdEVsRMxf7w2edipC6w8GqOL-7ctPhZdncN4KvUwIcCUh0omUhQe10squhDaIre_OaCfQEdWMutSMQokfHHSEv9rmpglqtILylbRhBeD5Cg1MVMWk8DJ2oQWmjs8eEje3lVsXKhRO2MXzaajRFxzNsRP5pZPVEELzLMYI6A_VRpmBBPMofJeBCoNB-3Iyyg4hCNdKWXrzEz7EgRjijiNrI8gAAE2XBjKOwb5mV3PDDHb6hWOImASQipEMGMRPdnuvt1THnwnC1V_9xJQlhVeD6B880boPs-=w1000-h1414-no";
            Link_CardInfo = @"https://lh3.googleusercontent.com/9Er9-nAhem3HJIKD2iqyywtc-bDKz-q9Ta2cxdHZdI24UNYs_a5QO0hpIaNbfIsM3iP_OH3AXJ2Eo9bMz8zIZReMchE7hwz3URCvS4kSecjj4EV14vj9PXPuTdpCLGDdryjDQS-ALeviehimPT8o8ym6pDUUINzNyS7JqqtB7WLjLJdw2yWlKNjw2TruTIa8meIJt5JTpdH43oeTNq3OaBFZY8pMKSBwAo-NWvT9XG7R_V8a3QjN4nWm23dEwop_xWce508yFwqCWvgFnclhbe-2M1no8CTYhWBzkgv-xyAXPe_lmfxHUoK4ULuuLrepUOnGQmNrslYbt8skmvGjvYIDLSC_UIwoj5mPAZP5rhU9gxLXxPEmGhzv2kheZIbl5C1XrZgg3FfpuhMTp9vGjJ7d5sAocjeDrwS8d-Gnqm5nzrP8IEOkA5sVEWB992AzgdrMD0f0COMyMCusIxKAxEiKyAq1Z411WbMrQbhInMYCML03OX_h7xw9-qdK_m3Ok_LIkj2ZcnF0mo4RxfB89Rnq4TjbDpbTh-ybeqPOBUEwYI6R_CA8j-ndHMRWlD9xAKn43Uk8a3-cwXW3GdL-jYuR8o4qtwAk8MNISdpWjdEltKXwp1e0KzS4L25o-oa5YxnZlfhcMd0EaFHov2MAXA-r_IVdPfNMGZdOn3aH5-Hc2eG8LhCv2RYhPBtVzAQbMXI43hqLcytVP4V_40rctaL4AHrbMH2Ya78hXlPR2feoHkzywsPq2w=w494-h698-no";
            Link_CheckInfo = @"https://lh3.googleusercontent.com/4n-9JH2TvLT8O9Ocf7uGNb8Y7E5KOVBLt636sEZdlash0nlrv1035_xzCEpcdnSbVai30pCoWgPFy2VY78l6aRsgXtqZaL_iDzqwziQiP51dqwxR2rjThR6WpaRO9nifn9wC_axoOf_66DX6DcnKCFivoNZPFlpP-bLhZ5y0IhjY9WTXgQgH4oRGl_K3sqpSX69XyHa-J4sCgTEUnHY-QCGYx7k1zKe9ejgz5NhYZlkgig1jtGOBiMFrC5lnAw4T6r6Bk-IdjPRE0JZY63wDbDW4xW_FFUCIiD1J-JgrjvjYNJX6YcZgZBSEJUBeiSE4dfri1y2vWJDucr_2B06J2j85N9HvaTtxh8YSfWwAd_dMW5GsBVDLd4YRcfnYVpn33vCplBZj202WudWbkfb75TMk0uTfMJahOQ5lTRg884N78Fws1j_88D-pvIkldvKESK72u0Zio6IRIuI0zLTOrvYA847sOlyfAMAvs-hWR2A30P_SL9pUKJJMoUEhLYVi3uo2ZLUlUISWDitizXDnl-8ECbh0nE6kZVKpIjGkhm_UUycvGgA1iKbsMLhvVhQ9mTQZ0h69d0zXFkJal9pAK8fdIcPTS9efMRyLdXs7KPl-pcagxQK4wWxoK6YClod15vaEKeE9BT9-6WyVN3-IvCdZgFUVJePq_NwoL3zgin7it7Qk22THyLPQ7-BRFdJ7SxnCkF3sHPi1pwIE5w1UhlfZxVBcDYlZDNsc6NQKnHoc7nicKCd4sA=w1000-h1414-no";

            Terminal_Vx680 = new Vx680();
            Terminal_Iwl250 = new Iwl250();
            Terminal_vx520 = new Vx520();
            Terminal_PAX900 = new PAX900();
            Terrminal_PartnerTech = new PartnerTech();
            ResponseCodes = new RespCodes();
            Contacts = new Contacts();
            Menu_General = new ReplyKeyboardMarkup(new[]
            {
                new[]{new KeyboardButton("Սարքեր") },
                new[]{new KeyboardButton("Հեռախոսահամարներ") },
                new[]{new KeyboardButton("Մերժման կոդերի աղյուսակ") },
                new[]{new KeyboardButton("Գանձապահի ուսուցում") }
            });
            Menu_Second = new ReplyKeyboardMarkup(new[]
            {
                new[]{new KeyboardButton("Verifone vx520 և vx680") },
                new[]{new KeyboardButton("ՀԴՄ PAX900") },
                new[]{new KeyboardButton("ՀԴՄ PartnerTech") },
                new[]{new KeyboardButton("Ingenico iWL250") },
                new[]{new KeyboardButton("Գլխավոր մենյու") }
            });
        }
    }
}
