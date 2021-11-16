using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;

namespace StockMarketChart.Admin.Services
{
    public interface IStockExchangeServices
    {
        void AddStockExchange(StockExchange stock);
        void DeleteStockExchange(string id);
        List<StockExchange> GetStockExchanges();
        StockExchange GetStockExchange(string stockid);
        void UpdateStockExchange(StockExchange stock);

    }
}
