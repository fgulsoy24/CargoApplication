using CargoApplication.Model;
using CargoApplication.Model.Repository;
using CargoApplication.Repository.Interface;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CargoApplication.Repository.Implementation
{
    public class CargoRepository : ICargoRepository
    {

        private static string connectionString;

        public CargoRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("CargoDb");
        }
        public List<PriceDetails> GetByDimension(int dimension, string companyName)
        {
            List<PriceDetails> result = new List<PriceDetails>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                result = connection.Query<PriceDetails>("Select * From dbo.PriceDetails where CompanyName = @companyName and (FromDimension < @dimension and ToDimension > @dimension)", new { Dimension = dimension, CompanyName = companyName }).ToList();
                return result;
            }
        }
        public List<PriceDetails> GetByWeight(int weight, string companyName)
        {
            List<PriceDetails> result = new List<PriceDetails>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                result = connection.Query<PriceDetails>("Select * From dbo.PriceDetails where CompanyName = @companyName and (FromWeight < @weight and ToWeight > @weight)", new { Weight = weight, CompanyName = companyName }).ToList();
                return result;
            }
        }
    }
}
