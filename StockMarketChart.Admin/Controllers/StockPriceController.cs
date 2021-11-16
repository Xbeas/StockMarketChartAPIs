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
    public class StockPriceController : ControllerBase
    {
        private readonly StockPriceServices stockServices = new StockPriceServices();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetStockPrice()
        {
            try
            {
                List<StockPrice> stock = stockServices.GetStockPrices();
                return Ok(stock);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetStockPrice/{stockid}")]
        public IActionResult GetStockPrice(int stockid)
        {
            try
            {
                StockPrice stock = stockServices.GetStockPrice(stockid);
                return Ok(stock);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddStockPrice")]
        public IActionResult Add(StockPrice stock)
        {
            try
            {
                Console.WriteLine(JsonConvert.SerializeObject(stock, Formatting.Indented));
                stockServices.AddStockPrice(stock);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Update(StockPrice stock)
        {
            try
            {
                stockServices.UpdateStockPrice(stock);
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
                stockServices.DeleteStockPrice(id);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

    }
}
