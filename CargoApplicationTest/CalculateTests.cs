using CargoApplication.Model;
using CargoApplication.Service.Implementation;
using NUnit.Framework;
using Moq;
using CargoApplication.Service.Interface;
using CargoApplication.Repository.Interface;
using CargoApplication.Model.Repository;
using System.Collections.Generic;
using CargoApplication.Factory;

namespace CargoApplicationTest
{
    public class Tests
    {

        [Test]
        public void TestCalculateByDimensionCargo4You()
        {
            var mock = new Mock<ICargoRepository>();
            mock.Setup(p => p.GetByDimension(1200, "Cargo 4 You")).Returns(new List<PriceDetails>());

            Cargo4YouFactory cargo4YouFactory = new Cargo4YouFactory(mock.Object, 1200 , 12);
            var result = cargo4YouFactory.CalculateByDimension();
            Assert.AreEqual(new List<PriceDetails>(), result);
        }
        [Test]
        public void TestCalculateByDimensionMaltaShip()
        {
            var mock = new Mock<ICargoRepository>();
            mock.Setup(p => p.GetByDimension(3000, "Malta Ship")).Returns(new List<PriceDetails>());

            MaltaShipFactory maltaShipFactory = new MaltaShipFactory(mock.Object, 3000, 60);
            var result = maltaShipFactory.CalculateByDimension();
            Assert.AreEqual(new List<PriceDetails>(), result);
        }
        [Test]
        public void TestCalculateByDimensionShipFaster()
        {
            var mock = new Mock<ICargoRepository>();
            mock.Setup(p => p.GetByDimension(2000, "Ship Faster")).Returns(new List<PriceDetails>());

            ShipFasterFactory shipFaster = new ShipFasterFactory(mock.Object, 2000, 30);
            var result = shipFaster.CalculateByDimension();
            Assert.AreEqual(new List<PriceDetails>(), result);
        }
    }
}