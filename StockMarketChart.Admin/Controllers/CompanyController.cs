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
    public class CompanyController : ControllerBase
    {
        private readonly CompanyServices companyServices = new CompanyServices();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetCompany()
        {
            try
            {
                List<Company> company = companyServices.GetCompanies();
                return Ok(company);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetCompany/{companyid}")]
        public IActionResult GetCompany(string companyid)
        {
            try
            {
                Company company = companyServices.GetCompany(companyid);
                return Ok(company);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(Company company)
        {
            try
            {
                Console.WriteLine(JsonConvert.SerializeObject(company, Formatting.Indented));
                companyServices.AddCompany(company);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Update(Company company)
        {
            try
            {
                companyServices.UpdateCompany(company);
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
                companyServices.DeleteCompany(id);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
