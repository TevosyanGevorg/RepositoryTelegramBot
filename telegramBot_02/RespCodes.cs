using System;
using System.Collections.Generic;

namespace telegramBot_02
{
    public class RespCodes
    {
        Dictionary<string, string> responseCodes = new Dictionary<string, string>();
        public RespCodes()
        {
            responseCodes.Add("000", "Հաստատված է" + "\n" + "Авторизован" + "\n" + "Approved");
            responseCodes.Add("001", "Քարտապանի ինքնության հաստատում" + "\n" + "Требуется идентификация личности" + "\n" + "Honr W/Id");
            responseCodes.Add("005", "Գործարքը հնարավոր չէ կատարել" + "\n" + "Невозможно обработать транзакцию" + "\n" + "Unable To Process");
            responseCodes.Add("095", "Անվավեր գործարքի գումարը գերազանցում է վաճառքի գումարը" + "\n" + "Реверсал осуществляется на сумму большую, чем оригинальная транзакция" + "\n" + "Reconcilation Error");
            responseCodes.Add("100", "Կասկածելի քարտ։ Մերժել գործարքը" + "\n" + "Подозрительная карта․ Отказать в обслуживании" + "\n" + "Worm card");
            responseCodes.Add("101", "Վավերականության ժամկետը լրացել է, վերցնել քարտը" + "\n" + "Карта просрочена, изъять карту" + "\n" + "Expired card");
            responseCodes.Add("103", "Զանգել քարտը թողարկող բանկ" + "\n" + "Позвонить эмитенту" + "\n" + "Call issuer");
            responseCodes.Add("104", "Քարտի սահմանափակում" + "\n" + "Карта ограничена" + "\n" + "Card declined");
            responseCodes.Add("106", "Գերազանցվել է Pin-երի հավաքման թույլատրելի քանակը" + "\n" + "Превышено допустимое число попыток ввода Pin" + "\n" + "Pin-tries exceed");
            responseCodes.Add("107", "Զանգել քարտը թողարկող բանկ" + "\n" + "Позвонить эмитенту" + "\n" + "Call issuer");
            responseCodes.Add("109", "Առևտրային կետի համարի սխալ (Merchant ID)" + "\n" + "Недействительный идентификатор торговой организации (Merchant ID)" + "\n" + "Invalid merchant");
            responseCodes.Add("110", "Սխալ գումար" + "\n" + "Невозможно обработать сумму" + "\n" + "Invalid amount");
            responseCodes.Add("111", "Անվավեր քարտ" + "\n" + "Недействительная карта" + "\n" + "Invalid card");
            responseCodes.Add("116", "Անբավարար Միջոցներ" + "\n" + "Недостаточно денег" + "\n" + "Insufficient funds");
            responseCodes.Add("117", "Սխալ Pin" + "\n" + "Неверный Pin" + "\n" + "Incorrect pin");
            responseCodes.Add("119", "Գործարքը թույլատրված չէ" + "\n" + "Транзакция не законна" + "\n" + "Security violation");
            responseCodes.Add("120", "Գործարքը թույլատրված չէ" + "\n" + "Не разрешено" + "\n" + "Not allowed");
            responseCodes.Add("121", "Գումարը գերազանցում է սպասարկողի կողմից սահմանված չափը" + "\n" + "Запрашиваемая сумма выходит за пределы диапазона, разрешенного эмитентом" + "\n" + "Excds wdrwl limt");
            responseCodes.Add("123", "Գերազանցված է գործարքների թույլատրելի քանակը" + "\n" + "Превышено циклический лимит POS-терминалам" + "\n" + "Excds wdrwl ltmt");
            responseCodes.Add("125", "Անվավեր քարտ" + "\n" + "Недействительная карта" + "\n" + "Invalid card");
            responseCodes.Add("200", "Անվավեր քարտ" + "\n" + "Недействительная карта" + "\n" + "Invalid card");
            responseCodes.Add("202", "Անվավեր քարտ" + "\n" + "Недействительная карта" + "\n" + "Invalid card");
            responseCodes.Add("203", "Վերցնել քարտը" + "\n" + "Изъять карту" + "\n" + "Pick-up card");
            responseCodes.Add("204", "Վերցնել քարտը" + "\n" + "Изъять карту" + "\n" + "Pick-up card");
            responseCodes.Add("206", "Սխալ Pin, Վերցնել քարտը" + "\n" + "Неверный Pin, изъять карту" + "\n" + "Deny pin capture");
            responseCodes.Add("208", "Վերցնել քարտը" + "\n" + "Изъять карту" + "\n" + "Pick-up card");
            responseCodes.Add("209", "Վերցնել քարտը" + "\n" + "Изъять карту" + "\n" + "Pick-up card");
            responseCodes.Add("902", "Հնարավոր չէ կատարել գործարքը " + "\n" + "Невозможно обработать транзакцию" + "\n" + "Invalid trans.");
            responseCodes.Add("903", "Կրկին կատարել գործարքը" + "\n" + "Повторить транзакцию " + "\n" + "Re-Enter trans.");
            responseCodes.Add("904", "Պատասխանի սխալ" + "\n" + "Полученное сообщение не соответствует стандарту " + "\n" + "Format error");
            responseCodes.Add("907", "Գործարքը թույլատրված չէ" + "\n" + "Проведение операции не разрешено " + "\n" + "Host not avail.");
            responseCodes.Add("909", "Զանգել քարտը թողարկող բանկ" + "\n" + "Позвонить эмитенту" + "\n" + "Call issuer");
            responseCodes.Add("910", "Հնարավոր չէ կատարել գործարքը" + "\n" + "Не получилось успешно выполнить транзакцию" + "\n" + "Host not avail");
            responseCodes.Add("913", "Կրկնակի գործարք" + "\n" + "Дублирование транзакции" + "\n" + "Invalid trans.");
            responseCodes.Add("914", "Իրական գործարքը բացակայում է" + "\n" + "Невозможно найти оригинальную транзакцию" + "\n" + "Orig trans. not found");
            responseCodes.Add("920", "Pin-ի մշակման սխալ (Զանգահարեք POS terminal-ների սպասարկման խումբ)" + "\n" + "Ошибка обработки Pin (Позвонить специалисту по POS terminal)" + "\n" + "Pin error (Call POS support team)");
            responseCodes.Add("940", "Վերցնել քարտը" + "\n" + "Изъять карту, специальные условия" + "\n" + "Capture card spec");
            responseCodes.Add("Z3", "Կապի խնդիր" + "\n" + "Проблема соединения" + "\n" + "Decline");
            responseCodes.Add("1Z3", "Կապի խնդիր" + "\n" + "Проблема соединения" + "\n" + "Decline");
        }
        public string FindResponse(string codde)
        {
            string text_resp_cod = "Սխալ մուտքագրված կոդ";
            foreach (KeyValuePair<string, string> keyValue in responseCodes)
            {
                if (keyValue.Key == codde.ToUpper())
                {
                    text_resp_cod = keyValue.Value;
                    return text_resp_cod;
                }
            }
            return text_resp_cod;
        }
    }

}
