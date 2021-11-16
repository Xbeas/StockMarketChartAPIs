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
    public class IPODetailsController : ControllerBase
    {
        private readonly IPODetailsServices ipoServices = new IPODetailsServices();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetIPODetails()
        {
            try
            {
                List<IPODetails> ipo = ipoServices.GetIPODetailss();
                return Ok(ipo);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetIPODetails/{ipoid}")]
        public IActionResult GetIPODetails(int ipoid)
        {
            try
            {
                IPODetails ipo = ipoServices.GetIPODetails(ipoid);
                return Ok(ipo);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(IPODetails ipo)
        {
            try
            {
                Console.WriteLine(JsonConvert.SerializeObject(ipo, Formatting.Indented));
                ipoServices.AddIPODetails(ipo);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Update(IPODetails ipo)
        {
            try
            {
                ipoServices.UpdateIPODetails(ipo);
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
                ipoServices.DeleteIPODetails(id);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

    }
}
