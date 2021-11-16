using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;

namespace StockMarketChart.Admin.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly StockMarketDBContext db = new StockMarketDBContext();

        public void AddCompany(Company company)
        {
            db.Companies.Add(company);
            db.SaveChanges();
        }
        public void DeleteCompany(Company company)
        {
            
            db.Companies.Remove(company);
            db.SaveChanges();
        }

        public List<Company> GetCompanies()
        {
            return db.Companies.ToList();
        }

        public Company GetCompany(string companyid)
        {

            Company company = db.Companies.Find(companyid);
          
            return company;

        }

        public void UpdateCompany(Company company)
        {
            db.Companies.Update(company);
            db.SaveChanges();
        }
        public List<StockPrice> GetStockPrices(string cname) {
            Company c = db.Companies.Find(cname);
            if (c == null)
            {
                return null;
            }
            return db.StockPrices.Where(cc => cc.company_id == c.id).ToList();
        }

    }
}
