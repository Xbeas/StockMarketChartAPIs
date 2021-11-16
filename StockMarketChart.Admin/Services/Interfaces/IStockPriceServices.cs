using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;

namespace StockMarketChart.Admin.Services
{
    public interface IStockPriceServices
    {
        void AddStockPrice(StockPrice stock);
        void DeleteStockPrice(int id);
        List<StockPrice> GetStockPrices();
        StockPrice GetStockPrice(int stockid);
        void UpdateStockPrice(StockPrice stock);

    }
}
