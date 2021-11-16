using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;

namespace StockMarketChart.Admin.Services
{
    public interface IIPODetailsServices
    {
        void AddIPODetails(IPODetails ipo);
        void DeleteIPODetails(int id);
        List<IPODetails> GetIPODetailss();
        IPODetails GetIPODetails(int ipoid);
        void UpdateIPODetails(IPODetails ipo);

    }
}
