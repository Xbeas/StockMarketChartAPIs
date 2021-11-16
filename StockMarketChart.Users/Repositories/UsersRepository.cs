using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
using StockMarketChart.Users.Repositories;
using StockMarketChart.Users.Models;
namespace StockMarketChart.Users.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly StockMarketDBContext db = new StockMarketDBContext();

        public void AddUser(User user)
        {

            db.Users.Add(user);
            db.SaveChanges();
        }
        public void DeleteUser(User user)
        {
            
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public List<User> GetUsers()
        {
            return db.Users.ToList();
        }

        public User GetUser(int userid)
        {

            User user = db.Users.Where(s => s.username == "strfddfddfing").Single();

            //if (user!=null)
               Console.WriteLine("weew", user); 
          
            return user;

        }

        public void UpdateUser(User user)
        {
            db.Users.Update(user);
            db.SaveChanges();
        }

        public User Validate(Login login)
        {
            User user = db.Users.SingleOrDefault(u => u.username.Equals(login.username) && u.password == login.password);
            return user;
        }
    }
}
