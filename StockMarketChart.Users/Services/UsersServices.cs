using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
using StockMarketChart.Users.Models;
using StockMarketChart.Users.Repositories;
namespace StockMarketChart.Users.Services
{
    public class UsersServices: IUsersServices
    {

        private readonly UsersRepository repository = new UsersRepository();

        public void AddUser(User user)
        {
            user.userType = "User";
            repository.AddUser(user);
        }
        public void DeleteUser(int id)
        {
            User user = this.GetUser(id);
            repository.DeleteUser(user);
        }

        public List<User> GetUsers()
        {
            return repository.GetUsers();
        }

        public User GetUser(int userid)
        {
            return repository.GetUser(userid);
        }

        public void UpdateUser(User user)
        {
            repository.UpdateUser(user);
        }
        public User Validate(Login login)
        {
            User user = repository.Validate(login);
            return user;
        }

    }
}
