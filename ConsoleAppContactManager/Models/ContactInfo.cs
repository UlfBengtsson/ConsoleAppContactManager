using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppContactManager.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string ContactType { get; set; }

        public string Name { get; set; }

        List<PhoneNumber> phoneNumbers;

        List<EmailAdress> emailAdresses;
        
        public AdressInfo AdressInfo { get; set; }

        public ContactInfo()
        {
            phoneNumbers = new List<PhoneNumber>();
            emailAdresses = new List<EmailAdress>();
        }

        public bool AddPhoneNumber(PhoneNumber phoneNumber)
        {
            if (phoneNumbers.Contains(phoneNumber))
            {
                return false;
            }
            else
            {
                foreach (PhoneNumber item in phoneNumbers)
                {
                    if (item.Number == phoneNumber.Number)
                    {
                        return false;
                    }
                }
                phoneNumbers.Add(phoneNumber);
                return true;
            }
        }

        public PhoneNumber[] FindPhoneNumberContaning(string numberPartOf)
        {
            List<PhoneNumber> hits = new List<PhoneNumber>();

            foreach (PhoneNumber item in phoneNumbers)
            {
                if (item.Number.Contains(numberPartOf))
                {
                    hits.Add(item);
                }
            }

            return hits.ToArray();
        }
    }
}
