using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CargoApplication.Model;
using CargoApplication.Service.Implementation;
using CargoApplication.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargoApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        public ICargoService service;
        public CargoController(ICargoService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        //POST: api/Cargo
        //param: width height, depth, weight
        //return: Offer
        [HttpPost]
        public IActionResult Post([FromBody] CalculateParam model)
        {
            try
            {
                var result = service.Calculate(model);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
