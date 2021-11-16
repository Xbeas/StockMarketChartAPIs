using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;
namespace StockMarketChart.Admin.Repositories
{
    public interface ICompanyRepository
    {
        void AddCompany(Company company);
        void DeleteCompany(Company company);
        List<Company> GetCompanies();
        Company GetCompany(string companyid);
        void UpdateCompany(Company company);

    }
}
