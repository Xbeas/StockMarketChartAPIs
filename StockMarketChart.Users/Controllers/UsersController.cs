using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Users.Services;
using StockMarketChart.Entities;
using Newtonsoft.Json;
using StockMarketChart.Users.Models;

namespace StockMarketChart.Users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersServices usersServices = new UsersServices();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetUsers()
        {
            try
            {
                List<User> users = usersServices.GetUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetUsers/{userid}")]
        public IActionResult GetUser(int userid)
        {
            try
            {
                User user = usersServices.GetUser(userid);
                return Ok(user);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(User user)
        {
            try
            {
                Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
                usersServices.AddUser(user);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Update(User user)
        {
            try
            {
                usersServices.UpdateUser(user);
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
                usersServices.DeleteUser(id);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("login")]
        public IActionResult LoginUser(Login login)
        {
            try
            {
                User user = usersServices.Validate(login);

                Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
                return Ok(JsonConvert.SerializeObject(user, Formatting.Indented));
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
