using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarketChart.Entities;

namespace StockMarketChart.Admin.Services
{
    public interface ICompanyServices
    {
        void AddCompany(Company company);
        void DeleteCompany(string id);
        List<Company> GetCompanies();
        Company GetCompany(string companyid);
        void UpdateCompany(Company company);

    }
}
