using CargoApplication.Model;
using CargoApplication.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoApplication.Factory
{
    public interface ICargoFactory
    {
        public abstract bool ValidateByDimension();
        public abstract bool ValidateByWeight();
        public abstract double CalculateByDimension();
        public abstract double CalculateByWeight();
        public abstract string CompanyName { get; set; }
        public Offer Calculate();
        public virtual string Currency { get => "€";}

    }
}
