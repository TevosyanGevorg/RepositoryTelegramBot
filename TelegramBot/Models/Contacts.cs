using System.Collections.Generic;

namespace TelegramBot.Models
{
    public class Contacts
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();
        public Contacts()
        {
            contacts.Add("\n098171845", "Գևորգ");
            contacts.Add("\n098171846", "Վաղինակ");
            contacts.Add("\n098171847", "Արամ");
            contacts.Add("\n099560515", "Միքաել");
            contacts.Add("\n043001067", "Էդուարդ");
            contacts.Add("\n043001068", "Ալբերտ");
            contacts.Add("\n010561111", "\nոչ աշխատանքային ժամերին՝");
        }
        public string Get()
        {
            string Resultcontacts = "POS terminal-ների սպասարկման խումբ՝\n\n";
            foreach (KeyValuePair<string, string> contact in contacts)
            {
                Resultcontacts = Resultcontacts.Insert(Resultcontacts.Length, contact.Value + " " + contact.Key + "\n");
            }
            Resultcontacts.Remove(Resultcontacts.Length - 2);
            return Resultcontacts;
        }
    }
}
