using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
namespace StockMarketChart.Admin.Repositories
{
    public interface IIPODetailsRepository
    {
        void AddIPODetails(IPODetails ipo);
        void DeleteIPODetails(IPODetails ipo);
        List<IPODetails> GetIPODetailss();
        IPODetails GetIPODetails(int ipoid);
        void UpdateIPODetails(IPODetails ipo);

    }
}
