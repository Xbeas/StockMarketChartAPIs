using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;

namespace StockMarketChart.Admin.Repositories
{
    public class SectorRepository : ISectorRepository
    {
        private readonly StockMarketDBContext db = new StockMarketDBContext();

        public void AddSector(Sector sector)
        {
            db.Sectors.Add(sector);
            db.SaveChanges();
        }
        public void DeleteSector(Sector sector)
        {
            
            db.Sectors.Remove(sector);
            db.SaveChanges();
        }

        public List<Sector> GetSectors()
        {
            return db.Sectors.ToList();
        }

        public Sector GetSector(int sectorid)
        {

            Sector sector = db.Sectors.Find(sectorid);

            //if (sector!=null)
               Console.WriteLine("weew", sector); 
          
            return sector;

        }

        public void UpdateSector(Sector sector)
        {
            db.Sectors.Update(sector);
            db.SaveChanges();
        }

    }
}
