using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
namespace StockMarketChart.Admin.Repositories
{
    public interface IStockPriceRepository
    {
        void AddStockPrice(StockPrice stock);
        void DeleteStockPrice(StockPrice stock);
        List<StockPrice> GetStockPrices();
        StockPrice GetStockPrice(int stockid);
        void UpdateStockPrice(StockPrice stock);

    }
}
