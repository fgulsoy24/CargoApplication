using CargoApplication.Model;
using CargoApplication.Model.Repository;
using CargoApplication.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoApplication.Factory
{
    public abstract class CargoFactory
    {
        public ICargoRepository _cargoRepository;

        public abstract List<PriceDetails> CalculateByDimension();
        public abstract List<PriceDetails> CalculateByWeight();
        public abstract string CompanyName { get; set; }
        public virtual string Currency { get => "€"; }
        public CargoFactory(ICargoRepository cargoRepository)
        {  
            _cargoRepository = cargoRepository;
        }
        public virtual Offer Calculate()
        {
            Offer offer = new Offer();
            offer.CompanyName = CompanyName;
            double priceByDimension = 0;
            double priceByWeight = 0;

            var priceDetailsByDimension = CalculateByDimension();
            var priceDetailsByWeight = CalculateByWeight();
            if (priceDetailsByDimension.Count <= 0 || priceDetailsByWeight.Count <= 0)
            {
                offer.ResultCode = 422;
                offer.ResultMessage = "Parameters are not valid";
                return offer;
            }
            priceByDimension = Math.Round(priceDetailsByDimension[0].Price, 2);
            priceByWeight = Math.Round(priceDetailsByWeight[0].Price, 2); 

            offer.ResultCode = 200;
            offer.ResultMessage = "Succeeded";

            if (priceByDimension > priceByWeight)
            {
                offer.Price = priceByDimension;
            }
            else
            {
                offer.Price = priceByWeight;
            }
            return offer;
        }


    }
}
