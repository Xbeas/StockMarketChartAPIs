using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;

namespace StockMarketChart.Admin.Repositories
{
    public class StockPriceRepository : IStockPriceRepository
    {
        private readonly StockMarketDBContext db = new StockMarketDBContext();

        public void AddStockPrice(StockPrice stock)
        {
            db.StockPrices.Add(stock);
            db.SaveChanges();
        }
        public void DeleteStockPrice(StockPrice stock)
        {
            
            db.StockPrices.Remove(stock);
            db.SaveChanges();
        }

        public List<StockPrice> GetStockPrices()
        {
            return db.StockPrices.ToList();
        }

        public StockPrice GetStockPrice(int stockid)
        {

            StockPrice stock = db.StockPrices.Find(stockid);

            //if (stock!=null)
               Console.WriteLine("weew", stock); 
          
            return stock;

        }

        public void UpdateStockPrice(StockPrice stock)
        {
            db.StockPrices.Update(stock);
            db.SaveChanges();
        }
    }
}
