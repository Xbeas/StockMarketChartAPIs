using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;

namespace StockMarketChart.Admin.Repositories
{
    public class IPODetailsRepository : IIPODetailsRepository
    {
        private readonly StockMarketDBContext db = new StockMarketDBContext();

        public void AddIPODetails(IPODetails ipo)
        {
            db.IPODetails.Add(ipo);
            db.SaveChanges();
        }
        public void DeleteIPODetails(IPODetails ipo)
        {
            
            db.IPODetails.Remove(ipo);
            db.SaveChanges();
        }

        public List<IPODetails> GetIPODetailss()
        {
            return db.IPODetails.ToList();
        }

        public IPODetails GetIPODetails(int ipoid)
        {

            IPODetails ipo = db.IPODetails.Find(ipoid);

            //if (ipo!=null)
               Console.WriteLine("weew", ipo); 
          
            return ipo;

        }

        public void UpdateIPODetails(IPODetails ipo)
        {
            db.IPODetails.Update(ipo);
            db.SaveChanges();
        }

    }
}
