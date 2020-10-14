using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppContactManager.Models
{
    class ContactInfo
    {
        public int Id { get; set; }

        List<PhoneNumber> phoneNumbers;

        public AdressInfo AdressInfo { get; set; }



    }
}
