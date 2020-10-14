using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppContactManager.Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }//creates a field of int id

        string numberType;
        public string NumberType
        {
            get { return numberType; } 
            set
            {
                if (string.IsNullOrWhiteSpace(value) == false)
                {
                    numberType = value;
                }
            } 
        }
        public string Number { get; set; }//look up RegEx

        public PhoneNumber(string number)
        {
            Number = number;
            NumberType = "Default";
        }
        public PhoneNumber(string numberType, string number) : this(number)
        {
                NumberType = numberType;
        }
    }
}
