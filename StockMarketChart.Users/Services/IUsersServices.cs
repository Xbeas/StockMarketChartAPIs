using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;

namespace StockMarketChart.Users.Services
{
    public interface IUsersServices
    {
        void AddUser(User user);
        void DeleteUser(int id);
        List<User> GetUsers();
        User GetUser(int userid);
        void UpdateUser(User user);

    }
}
