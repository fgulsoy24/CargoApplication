using CargoApplication.Model.Repository;
using CargoApplication.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoApplication.Factory
{
    public class ShipFasterFactory : CargoFactory
    {
        private int dimension;
        private int weight;
        private string _companyName;
        public override string CompanyName { get => _companyName; set => _companyName = "Ship Faster"; }
        public ShipFasterFactory(ICargoRepository _cargoRepository, int dimension, int weight) : base(_cargoRepository)
        {

            this.dimension = dimension;
            this.weight = weight;
            _companyName = "Ship Faster";
        }
    
        public override List<PriceDetails> CalculateByDimension()
        {
            return _cargoRepository.GetByDimension(dimension, _companyName);
        }
        public override List<PriceDetails> CalculateByWeight()
        {
            if (weight > 25)
            {
                List<PriceDetails> priceDetails = new List<PriceDetails>();
                double price = CalculateHighWeight(weight);
                priceDetails.Add(new PriceDetails { Price = price, CompanyName = CompanyName });
                return priceDetails;
            }
            return _cargoRepository.GetByWeight(weight, _companyName);
        }
        private double CalculateHighWeight(int weight)
        {
            double totalPrice = 40;
            for (int i = 0; i < weight; i++)
            {
                totalPrice = totalPrice + 0.417;
            }
            return totalPrice;
        }
    }
}
