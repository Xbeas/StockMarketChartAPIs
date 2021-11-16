using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
using StockMarketChart.Admin.Repositories;

namespace StockMarketChart.Admin.Services
{
    public class StockPriceServices: IStockPriceServices
    {

        private readonly StockPriceRepository repository = new StockPriceRepository();

        public void AddStockPrice(StockPrice stock)
        {
            repository.AddStockPrice(stock);
        }
        public void DeleteStockPrice(int id)
        {
            StockPrice stock = this.GetStockPrice(id);
            repository.DeleteStockPrice(stock);
        }

        public List<StockPrice> GetStockPrices()
        {
            return repository.GetStockPrices();
        }

        public StockPrice GetStockPrice(int stockid)
        {
            return repository.GetStockPrice(stockid);
        }

        public void UpdateStockPrice(StockPrice stock)
        {
            repository.UpdateStockPrice(stock);
        }


    }
}
