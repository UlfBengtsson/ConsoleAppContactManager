using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppContactManager.Models
{
    public class AdressInfo
    {
        public int Id { get; set; }

        public int StreetNumber { get; set; }
        public string EntreansName { get; set; }
        public string StreetName { get; set; }
        public string BoxNumber { get; set; }
        public string PostCode { get; set; }
        public string CityName { get; set; }

    }
}
