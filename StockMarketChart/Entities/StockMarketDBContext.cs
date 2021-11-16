using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StockMarketChart.Entities;

namespace StockMarketChart.Entities
{
    public class StockMarketDBContext: DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StockExchange> StockExchanges { get; set; }
        public DbSet<IPODetails> IPODetails { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=SOCDOTNET01\SQLEXPRESS;Initial Catalog=StockMarketDb;Integrated Security=True");
        }

    }
}
