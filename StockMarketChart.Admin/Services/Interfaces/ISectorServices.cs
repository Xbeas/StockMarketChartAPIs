using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;

namespace StockMarketChart.Admin.Services
{
    public interface ISectorServices
    {
        void AddSector(Sector sector);
        void DeleteSector(int id);
        List<Sector> GetSectors();
        Sector GetSector(int sectorid);
        void UpdateSector(Sector sector);

    }
}
