using CargoApplication.Factory;
using CargoApplication.Model;
using CargoApplication.Repository.Implementation;
using CargoApplication.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using CargoApplication.Service.Interface;

namespace CargoApplication.Service.Implementation
{
    
    public class CargoService : ICargoService
    {
        public ICargoRepository repository;
        public CargoService(ICargoRepository repository)
        {
            this.repository = repository;
        }
        //params 
        public Offer Calculate(CalculateParam calculatePriceModel)
        {
       
            var dimension = calculatePriceModel.Depth * calculatePriceModel.Height * calculatePriceModel.Width;
            List<Offer> offers = new List<Offer>();
            CargoFactory factoryCargo4You = new Cargo4YouFactory(repository, dimension, calculatePriceModel.Weight);
            Offer cargo4You = factoryCargo4You.Calculate();
            offers.Add(cargo4You);

            CargoFactory factoryShipFaster = new ShipFasterFactory(repository, dimension, calculatePriceModel.Weight);
            Offer shipFaster = factoryShipFaster.Calculate();
            offers.Add(shipFaster);

            CargoFactory factoryMaltaShip = new MaltaShipFactory(repository, dimension, calculatePriceModel.Weight);
            Offer maltaShip = factoryMaltaShip.Calculate();
            offers.Add(maltaShip);

       
            var validOffers = offers.Where(y => y.ResultCode == 200).ToList();
            if(validOffers.Count > 0)
            {
                validOffers = validOffers.Where(x => x.Price == validOffers.Min(z => z.Price)).ToList();
            }
            if (validOffers.Count == 0)
            {
                Offer offer = new Offer();
                offer.ResultCode = offers.FirstOrDefault().ResultCode;
                offer.ResultMessage = offers.FirstOrDefault().ResultMessage;
                return offer;
            }
            return validOffers[0];
        }


    }
}
