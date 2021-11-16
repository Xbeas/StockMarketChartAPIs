using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
using StockMarketChart.Admin.Repositories;

namespace StockMarketChart.Admin.Services
{
    public class SectorServices: ISectorServices
    {

        private readonly SectorRepository repository = new SectorRepository();

        public void AddSector(Sector sector)
        {
            repository.AddSector(sector);
        }
        public void DeleteSector(int id)
        {
            Sector sector = this.GetSector(id);
            repository.DeleteSector(sector);
        }

        public List<Sector> GetSectors()
        {
            return repository.GetSectors();
        }

        public Sector GetSector(int sectorid)
        {
            return repository.GetSector(sectorid);
        }

        public void UpdateSector(Sector sector)
        {
            repository.UpdateSector(sector);
        }


    }
}
