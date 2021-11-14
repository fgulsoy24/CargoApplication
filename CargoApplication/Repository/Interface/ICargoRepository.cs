using CargoApplication.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoApplication.Repository.Interface
{
    public interface ICargoRepository
    {
        public List<PriceDetails> GetByDimension(int dimension, string companyName);
        public List<PriceDetails> GetByWeight(int weight, string companyName);

    }
}
