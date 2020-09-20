using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
namespace telegramBot_02
{
    class MainClass
    {
        static TelegramBotClient Bot;
        static RespCodes respCodes = new RespCodes();

        public static void Main(string[] args)
        {
            Bot =new TelegramBotClient("1125804301:AAHKc9JfscNZHM_FODSOlM-pdb15FbfHiCQ");
            Bot.OnMessage += BotOnMessageRecived;
            Bot.OnCallbackQuery += BotOnCallbackQueryRecived;
            var me = Bot.GetMeAsync().Result;
            Console.WriteLine(me.FirstName);
            Bot.StartReceiving();
            Console.ReadKey();
            Bot.StopReceiving();
        }

        private static void BotOnCallbackQueryRecived(object sender, CallbackQueryEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static async void BotOnMessageRecived(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            if (message==null || message.Type != MessageType.Text) return;
            //================================test lisening===================================
            //string FLName = $"{message.From.FirstName} {message.From.LastName}";
            //Console.WriteLine(message.Text);
            //Console.WriteLine(FLName);
            //================================================================================
             
            switch (message.Text)
            {
            //================================================================================
                case "/start":
                    string name = $"{message.From.FirstName} {message.From.LastName}";
                    ReplyKeyboardMarkup Menu_General = new ReplyKeyboardMarkup(new[]{
                        new[]{new KeyboardButton("Տերմինալներ") },
                        new[]{new KeyboardButton("Հեռախոսահամարներ") },
                        new[]{new KeyboardButton("Մերժման կոդերի աղյուսակ") },
                        new[]{new KeyboardButton("Ուղեցույց") }
                    });
                    await Bot.SendTextMessageAsync(message.From.Id, $"բարև Ձեզ {name}, ընտրեք", replyMarkup: Menu_General);
                    break;
            //================================================================================
                case "Գլխավոր մենյու":
                    ReplyKeyboardMarkup Menu_General1 = new ReplyKeyboardMarkup(new[]{
                        new[]{new KeyboardButton("Տերմինալներ") },
                        new[]{new KeyboardButton("Հեռախոսահամարներ") },
                        new[]{new KeyboardButton("Մերժման կոդերի աղյուսակ") },
                        new[]{new KeyboardButton("Ուղեցույց") }
                    });
                    await Bot.SendTextMessageAsync(message.Chat.Id, "ընտրեք", replyMarkup: Menu_General1);
                    break;
            //================================================================================
                case "Տերմինալներ":
                    ReplyKeyboardMarkup Menu_Second = new ReplyKeyboardMarkup(new[]{
                        new[]{new KeyboardButton("Verifone vx520 և vx680") },
                        new[]{new KeyboardButton("ՀԴՄ PAX900") },
                        new[]{new KeyboardButton("ՀԴՄ PartnerTech") },
                        new[]{new KeyboardButton("Ingenico iWL250") },
                        new[]{new KeyboardButton("Գլխավոր մենյու") }
                    });
                    await Bot.SendTextMessageAsync(message.From.Id, "ընտրեք", replyMarkup: Menu_Second);
                    break;
            //================================================================================
                case "ՀԴՄ PartnerTech":
                    await Bot.SendPhotoAsync(message.From.Id, @"https://drive.google.com/file/d/1AqGU6sPbmY9etX56bR4bsU8R61JqkCuJ/view?usp=sharing");
                    InlineKeyboardMarkup PartnerTech = new InlineKeyboardMarkup(new[]{
                        new[]{InlineKeyboardButton.WithUrl("վաճառք-Purchase", @"https://drive.google.com/file/d/14AeTRpxsxwNJPW3D3XBCfbxfZvs7_cMC/view?usp=sharing") },
                        new[]{InlineKeyboardButton.WithUrl("անվավեր-Void", @"https://drive.google.com/file/d/1xVg4ti334HrTGfB_O3PKQqQqgVVp-cII/view?usp=sharing") },
                        new[]{InlineKeyboardButton.WithUrl("հետվճար-Refund", @"https://drive.google.com/file/d/1Qnk8cfWB2n0CmTwl6Q9szlabBFJ8mtXt/view?usp=sharing") },
                        new[]{InlineKeyboardButton.WithUrl("հավաստագրում-PrePurchase", @"https://drive.google.com/file/d/1vWEnfSYkkNeSHeMcrD4SUuRQ8vmuQDyb/view?usp=sharing") },
                        new[]{InlineKeyboardButton.WithUrl("հաստատում-Complete(PrePurchase)", @"https://drive.google.com/file/d/1BGvf909vxLwRqsSJ2PfYvVye5OkwByfL/view?usp=sharing") }
                    });
                    await Bot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: PartnerTech);
                    break;
            //================================================================================
                case "ՀԴՄ PAX900":
                    await Bot.SendPhotoAsync(message.From.Id, @"https://drive.google.com/file/d/11NUVACKj_7bVi1kY74JZj_DBnuIOKP1c/view?usp=sharing");
                    InlineKeyboardMarkup PAX900 = new InlineKeyboardMarkup(new[]
                    {
                        new[]{InlineKeyboardButton.WithUrl("վաճառք-Purchase", @"https://drive.google.com/file/d/1FuVH_IuVsqbksa2wWeHMZZL127YKdzE4/view?usp=sharing") },
                        new[]{InlineKeyboardButton.WithUrl("անվավեր-Void", @"https://drive.google.com/file/d/1HEw2d2NnHoaARGt9DUpOCffe-dgBMtXD/view?usp=sharing") },
                        new[]{InlineKeyboardButton.WithUrl("հետվճար-Refund", @"https://drive.google.com/file/d/1Dg1VEttLQFEZZ8xvXO0NQTdPwF4Gc9Wa/view?usp=sharing") },
                        new[]{InlineKeyboardButton.WithUrl("հավաստագրում-PrePurchase", @"https://drive.google.com/file/d/1wr8SxZUVML2oGwgisAGSue_D82wtjSHV/view?usp=sharing") },
                        new[]{InlineKeyboardButton.WithUrl("հաստատում-Complete(PrePurchase)", @"https://drive.google.com/file/d/1zskcwpSCGOOnC1Bf9ecvGCwY6E7VC8wY/view?usp=sharing") },
                    });
                    await Bot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: PAX900);
                    break;
            //================================================================================
                case "Verifone vx520 և vx680":
                    await Bot.SendPhotoAsync(message.From.Id, @"https://drive.google.com/file/d/1OPav8t_2-D-BrtvE-wDkLKnGzW0fMY-U/view?usp=sharing");
                    //await Bot.SendPhotoAsync(message.From.Id, dataForBot.Terminal_vx520.Photo);
                    InlineKeyboardMarkup Verifone = new InlineKeyboardMarkup(new[]
                    {
                        new[]{InlineKeyboardButton.WithUrl("վաճառք-Purchase", @"https://drive.google.com/file/d/1rKdClvu9w8Q9PGEAJl2OChXSU0aCpmZ_/view?usp=sharing") },
                        new[]{InlineKeyboardButton.WithUrl("անվավեր-Void", @"https://drive.google.com/file/d/1k39cw2lJlSbsI3fAtt9yy1df4beuszAU/view?usp=sharing") },
                        new[]{InlineKeyboardButton.WithUrl("հետվճար-Refund", @"https://drive.google.com/file/d/1ZymS4pbw5sBWVIeykQ5fCxltit5BwO2k/view?usp=sharing") },
                        new[]{InlineKeyboardButton.WithUrl("հավաստագրում-PrePurchase", @"https://drive.google.com/file/d/12sYqBJ_QJH7p-4AOwmz6dEyaQRoK5daM/view?usp=sharing") },
                        new[]{InlineKeyboardButton.WithUrl("հաստատում-Complete(PrePurchase)", @"https://drive.google.com/file/d/1WmZapYh8aptWAXntShwd8sibnmVSV4re/view?usp=sharing") },
                    });
                    await Bot.SendTextMessageAsync(message.From.Id, "ընտրեք կարգավորումը", replyMarkup: Verifone);
                    break;
                //case "/Ingenico iWL250":
                //    await Bot.SendPhotoAsync(message.From.Id, @"https://drive.google.com/file/d/1rVrKXYuAqIvC5XCA2yeypL7gziYXZvBi/view?usp=sharing");
                //    await Bot.SendTextMessageAsync(message.From.Id, "ընտրեք գործարքը", replyMarkup: dataForBot.Terminal_Iwl250.inlineKeybord);
                //    break;
                case "Հեռախոսահամարներ":
                    string contacts= "\n098171845 Գևորգ \n098171846 Վաղինակ\n098171847 Արամ\n099560515 Միքաել\n043001067 Էդուարդ\n043001068 Ալբերտ\nոչ աշխատանքային ժամերին՝ 010561111";
                    await Bot.SendTextMessageAsync(message.From.Id, contacts);
                    break;
                case "Մերժման կոդերի աղյուսակ":
                    string resposCode = respCodes.FindResponse(message.Text);
                    await Bot.SendPhotoAsync(message.From.Id, @"https://lh3.googleusercontent.com/VqiIxmxtZWnM-eZKo9-fQmAvqknhbnWQivxKH0enQZxhFFB0IGY32dmMPG73puk9Z0tjiQM399cHYujH3BmDv2V09VvY_o_RQYb0QBJVWcLmFt-hOYovCOEf3tCjju2rlywGP85ORtvggI4ODHZ6MVkHiwmAUnR-Co8z-zjr5rwRG1RFoYQo9HI1TJrtlDdm_R1dPJD3XM5E5A4Zt_H8H_ICbRBZRDeywKQXhV10XVt9qYoLzEFWzjh69767UxrJWHzeXlsXLc6-ysiVwjutYP8NmdD1syGpifxmFKsb9arJjvhM1R513hLom84YtIxWIBO67VgOVwr1A6cUCJoIPST3_jSNZYnFR91nZ5K4a8zWlyhFsaUGwIS7KpwqEqthcalvn8bu7MxRRjY7p6J-VYdm1F-GFHAFpFeLZZP48ZOOSk0c_PnE-nfmlncI67HS7OAjD1-MOEy65bWmr9ByslZPwX2MEd98HKfMrNL8UllrR1k7r3OSTmylBil55FKwXSqa-4JaMdavOCbF9NBafRPoqHsNYSSyNVuwyz-HygiK6EkaCI3VTCuQqZm4S8-ni_8R7OAAg9Mvso0bIDA_RlsgBUKkmtTMF1QIfhOpNQNNJerWvpeFv4qHKnTMVIlwP-y2l1CVJZUZL0FWa7VBNghRO3oMFnfeQ9lBtJPjwfkyNWtmh9YGlMGgCbEdOUabds4tpUYinvse1_KHrm7CB5RpT04h60O0uVHXaMw9zu7Ob0kPpZ81Gg=w1000-h1414-no");
                    break;
                case "Ուղեցույց":
                    await Bot.SendPhotoAsync(message.From.Id, @"https://lh3.googleusercontent.com/nVSGi67meMkUa1bw28bExJ6-BOcrbNHDkEcgzAGE4CB220wpUk5at8YDQ1-dkFYKxYeNh_-_GlaBOXJ-vjWumyHKVoNT7a38T9CSJh0iHO8t2_sBtCreQjyOGj2QooG3IedO10ITX6cRVIcCwhnb3Ea2lTLiFsMwLPJaytxvR4QnEzl0pgAOjeGZHt_Q8f9PjiwNUhW6kNMBsQgy5OMuo7NZQTR9_UQfRsduqwFzCEN-Q_A0L23yQTl8yI74ge7-C8PwpltQFjcxU4Ihx7rhiXgR5todn2SzUINogj8SLXYIfunUS9Ojn2U9Pza61rlNI3662BVuHNHuusCMKMdfbLn7olHM8b8U_YgqbNdC5T58cp-0cQihpEDj1vWIst5a1CYD1M5btSWJtHTekHeeP_oNERvieJdEVsRMxf7w2edipC6w8GqOL-7ctPhZdncN4KvUwIcCUh0omUhQe10squhDaIre_OaCfQEdWMutSMQokfHHSEv9rmpglqtILylbRhBeD5Cg1MVMWk8DJ2oQWmjs8eEje3lVsXKhRO2MXzaajRFxzNsRP5pZPVEELzLMYI6A_VRpmBBPMofJeBCoNB-3Iyyg4hCNdKWXrzEz7EgRjijiNrI8gAAE2XBjKOwb5mV3PDDHb6hWOImASQipEMGMRPdnuvt1THnwnC1V_9xJQlhVeD6B880boPs-=w1000-h1414-no");
                    await Bot.SendPhotoAsync(message.From.Id, @"https://lh3.googleusercontent.com/9Er9-nAhem3HJIKD2iqyywtc-bDKz-q9Ta2cxdHZdI24UNYs_a5QO0hpIaNbfIsM3iP_OH3AXJ2Eo9bMz8zIZReMchE7hwz3URCvS4kSecjj4EV14vj9PXPuTdpCLGDdryjDQS-ALeviehimPT8o8ym6pDUUINzNyS7JqqtB7WLjLJdw2yWlKNjw2TruTIa8meIJt5JTpdH43oeTNq3OaBFZY8pMKSBwAo-NWvT9XG7R_V8a3QjN4nWm23dEwop_xWce508yFwqCWvgFnclhbe-2M1no8CTYhWBzkgv-xyAXPe_lmfxHUoK4ULuuLrepUOnGQmNrslYbt8skmvGjvYIDLSC_UIwoj5mPAZP5rhU9gxLXxPEmGhzv2kheZIbl5C1XrZgg3FfpuhMTp9vGjJ7d5sAocjeDrwS8d-Gnqm5nzrP8IEOkA5sVEWB992AzgdrMD0f0COMyMCusIxKAxEiKyAq1Z411WbMrQbhInMYCML03OX_h7xw9-qdK_m3Ok_LIkj2ZcnF0mo4RxfB89Rnq4TjbDpbTh-ybeqPOBUEwYI6R_CA8j-ndHMRWlD9xAKn43Uk8a3-cwXW3GdL-jYuR8o4qtwAk8MNISdpWjdEltKXwp1e0KzS4L25o-oa5YxnZlfhcMd0EaFHov2MAXA-r_IVdPfNMGZdOn3aH5-Hc2eG8LhCv2RYhPBtVzAQbMXI43hqLcytVP4V_40rctaL4AHrbMH2Ya78hXlPR2feoHkzywsPq2w=w494-h698-no");
                    await Bot.SendPhotoAsync(message.From.Id, @"https://lh3.googleusercontent.com/4n-9JH2TvLT8O9Ocf7uGNb8Y7E5KOVBLt636sEZdlash0nlrv1035_xzCEpcdnSbVai30pCoWgPFy2VY78l6aRsgXtqZaL_iDzqwziQiP51dqwxR2rjThR6WpaRO9nifn9wC_axoOf_66DX6DcnKCFivoNZPFlpP-bLhZ5y0IhjY9WTXgQgH4oRGl_K3sqpSX69XyHa-J4sCgTEUnHY-QCGYx7k1zKe9ejgz5NhYZlkgig1jtGOBiMFrC5lnAw4T6r6Bk-IdjPRE0JZY63wDbDW4xW_FFUCIiD1J-JgrjvjYNJX6YcZgZBSEJUBeiSE4dfri1y2vWJDucr_2B06J2j85N9HvaTtxh8YSfWwAd_dMW5GsBVDLd4YRcfnYVpn33vCplBZj202WudWbkfb75TMk0uTfMJahOQ5lTRg884N78Fws1j_88D-pvIkldvKESK72u0Zio6IRIuI0zLTOrvYA847sOlyfAMAvs-hWR2A30P_SL9pUKJJMoUEhLYVi3uo2ZLUlUISWDitizXDnl-8ECbh0nE6kZVKpIjGkhm_UUycvGgA1iKbsMLhvVhQ9mTQZ0h69d0zXFkJal9pAK8fdIcPTS9efMRyLdXs7KPl-pcagxQK4wWxoK6YClod15vaEKeE9BT9-6WyVN3-IvCdZgFUVJePq_NwoL3zgin7it7Qk22THyLPQ7-BRFdJ7SxnCkF3sHPi1pwIE5w1UhlfZxVBcDYlZDNsc6NQKnHoc7nicKCd4sA=w1000-h1414-no");
                    break;

                default:
                    break;
            }
            if (message.Text.Length >= 2 && message.Text.Length <= 3)
            {
                string request = respCodes.FindResponse(message.Text);
                await Bot.SendTextMessageAsync(message.From.Id, request);
            }
        }
    }
}
