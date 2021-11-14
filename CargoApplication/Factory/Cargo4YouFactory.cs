using CargoApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using CargoApplication.Repository.Interface;
using CargoApplication.Model.Repository;

namespace CargoApplication.Factory
{
    public class Cargo4YouFactory : CargoFactory
    {
        private int dimension;
        private int weight;
        private string _companyName;
        public override string CompanyName { get => _companyName; set => _companyName = "Cargo 4 You"; }

        public Cargo4YouFactory(ICargoRepository _cargoRepository, int dimension, int weight) : base(_cargoRepository)
        {
  
            this.dimension = dimension;
            this.weight = weight;
            _companyName = "Cargo 4 You";
            
        }
        public override List<PriceDetails> CalculateByDimension()
        {
            return _cargoRepository.GetByDimension(dimension, _companyName);
        }
        public override List<PriceDetails> CalculateByWeight()
        {
           return _cargoRepository.GetByWeight(weight, _companyName);
        }

    }
}
