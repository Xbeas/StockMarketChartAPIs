using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
namespace StockMarketChart.Admin.Repositories
{
    public interface IStockExchangeRepository
    {
        void AddStockExchange(StockExchange stock);
        void DeleteStockExchange(StockExchange stock);
        List<StockExchange> GetStockExchanges();
        StockExchange GetStockExchange(string stockid);
        void UpdateStockExchange(StockExchange stock);

    }
}
