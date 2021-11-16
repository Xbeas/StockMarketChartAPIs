using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
using StockMarketChart.Admin.Repositories;

namespace StockMarketChart.Admin.Services
{
    public class CompanyServices: ICompanyServices
    {

        private readonly CompanyRepository repository = new CompanyRepository();

        public void AddCompany(Company company)
        {
            repository.AddCompany(company);
        }
        public void DeleteCompany(string id)
        {
            Company company = this.GetCompany(id);
            repository.DeleteCompany(company);
        }

        public List<Company> GetCompanies()
        {
            return repository.GetCompanies();
        }

        public Company GetCompany(string companyid)
        {
            return repository.GetCompany(companyid);
        }

        public void UpdateCompany(Company company)
        {
            repository.UpdateCompany(company);
        }


    }
}
