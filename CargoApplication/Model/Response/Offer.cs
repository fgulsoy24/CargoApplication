using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoApplication.Model
{
    public class Offer
    {
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public string CompanyName{ get; set; }
        public double Price { get; set; }
    }
}
