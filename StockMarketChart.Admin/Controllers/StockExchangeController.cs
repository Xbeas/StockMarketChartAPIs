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
    public class StockExchangeController : ControllerBase
    {
        private readonly StockExchangeServices stockServices = new StockExchangeServices();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetStockExchange()
        {
            try
            {
                List<StockExchange> stock = stockServices.GetStockExchanges();
                return Ok(stock);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetStockExchange/{stockid}")]
        public IActionResult GetStockExchange(string stockid)
        {
            try
            {
                StockExchange stock = stockServices.GetStockExchange(stockid);
                return Ok(stock);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddStockExchange")]
        public IActionResult Add(StockExchange stock)
        {
            try
            {
                Console.WriteLine(JsonConvert.SerializeObject(stock, Formatting.Indented));
                stock.timestamp = DateTime.UtcNow;
                stockServices.AddStockExchange(stock);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.InnerException.Message);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Update(StockExchange stock)
        {
            try
            {
                stockServices.UpdateStockExchange(stock);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("delete/{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                stockServices.DeleteStockExchange(id);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

    }
}
