using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoApplication.Model.Repository
{
    public class PriceDetails
    {
        public string CompanyName { get; set; }
        public int FromDimension{ get; set; }
        public int ToDimension { get; set; }
        public int FromWeight { get; set; }
        public int ToWeight { get; set; }
        public double Price{ get; set; }
    }
}
