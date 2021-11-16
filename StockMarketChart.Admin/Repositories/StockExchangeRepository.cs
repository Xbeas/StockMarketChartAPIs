using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;

namespace StockMarketChart.Admin.Repositories
{
    public class StockExchangeRepository : IStockExchangeRepository
    {
        private readonly StockMarketDBContext db = new StockMarketDBContext();

        public void AddStockExchange(StockExchange stock)
        {
            db.StockExchanges.Add(stock);
            db.SaveChanges();
        }
        public void DeleteStockExchange(StockExchange stock)
        {
            
            db.StockExchanges.Remove(stock);
            db.SaveChanges();
        }

        public List<StockExchange> GetStockExchanges()
        {
            return db.StockExchanges.ToList();
        }

        public StockExchange GetStockExchange(string stockid)
        {

            StockExchange stock = db.StockExchanges.Find(stockid);
          
            return stock;

        }

        public void UpdateStockExchange(StockExchange stock)
        {
            db.StockExchanges.Update(stock);
            db.SaveChanges();
        }

    }
}
