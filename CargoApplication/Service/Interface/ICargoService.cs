using CargoApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoApplication.Service.Interface
{
    public interface ICargoService
    {
        public Offer Calculate(CalculateParam calculatePriceModel);
    }
}
