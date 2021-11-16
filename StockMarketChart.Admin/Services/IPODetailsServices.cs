using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
using StockMarketChart.Admin.Repositories;

namespace StockMarketChart.Admin.Services
{
    public class IPODetailsServices: IIPODetailsServices
    {

        private readonly IPODetailsRepository repository = new IPODetailsRepository();

        public void AddIPODetails(IPODetails ipo)
        {
            repository.AddIPODetails(ipo);
        }
        public void DeleteIPODetails(int id)
        {
            IPODetails ipo = this.GetIPODetails(id);
            repository.DeleteIPODetails(ipo);
        }

        public List<IPODetails> GetIPODetailss()
        {
            return repository.GetIPODetailss();
        }

        public IPODetails GetIPODetails(int ipoid)
        {
            return repository.GetIPODetails(ipoid);
        }

        public void UpdateIPODetails(IPODetails ipo)
        {
            repository.UpdateIPODetails(ipo);
        }


    }
}
