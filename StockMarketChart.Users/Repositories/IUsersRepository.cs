using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
namespace StockMarketChart.Users.Repositories
{
    public interface IUsersRepository
    {
        void AddUser(User user);
        void DeleteUser(User user);
        List<User> GetUsers();
        User GetUser(int userid);
        void UpdateUser(User user);

    }
}
