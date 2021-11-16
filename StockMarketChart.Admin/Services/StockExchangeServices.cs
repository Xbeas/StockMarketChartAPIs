using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
using StockMarketChart.Admin.Repositories;

namespace StockMarketChart.Admin.Services
{
    public class StockExchangeServices: IStockExchangeServices
    {

        private readonly StockExchangeRepository repository = new StockExchangeRepository();

        public void AddStockExchange(StockExchange stock)
        {
            repository.AddStockExchange(stock);
        }
        public void DeleteStockExchange(string id)
        {
            StockExchange stock = this.GetStockExchange(id);
            repository.DeleteStockExchange(stock);
        }

        public List<StockExchange> GetStockExchanges()
        {
            return repository.GetStockExchanges();
        }

        public StockExchange GetStockExchange(string stockid)
        {
            return repository.GetStockExchange(stockid);
        }

        public void UpdateStockExchange(StockExchange stock)
        {
            repository.UpdateStockExchange(stock);
        }


    }
}
