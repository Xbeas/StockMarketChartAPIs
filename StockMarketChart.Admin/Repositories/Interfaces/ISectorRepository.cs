using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
namespace StockMarketChart.Admin.Repositories
{
    public interface ISectorRepository
    {
        void AddSector(Sector sector);
        void DeleteSector(Sector sector);
        List<Sector> GetSectors();
        Sector GetSector(int sectorid);
        void UpdateSector(Sector sector);

    }
}
