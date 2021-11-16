using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
using StockMarketChart.Admin.Services;
using Newtonsoft.Json;

namespace StockMarketChart.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        private readonly SectorServices sectorServices = new SectorServices();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetSector()
        {
            try
            {
                List<Sector> sector = sectorServices.GetSectors();
                return Ok(sector);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetSector/{sectorid}")]
        public IActionResult GetSector(int sectorid)
        {
            try
            {
                Sector sector = sectorServices.GetSector(sectorid);
                return Ok(sector);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddSector")]
        public IActionResult Add(Sector sector)
        {
            try
            {
                Console.WriteLine(JsonConvert.SerializeObject(sector, Formatting.Indented));
                sectorServices.AddSector(sector);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Update(Sector sector)
        {
            try
            {
                sectorServices.UpdateSector(sector);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                sectorServices.DeleteSector(id);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

    }
}
