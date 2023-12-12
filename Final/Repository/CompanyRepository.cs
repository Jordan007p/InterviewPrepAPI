using Final.Data;
using Final.Interfaces;
using Final.Models;

namespace Final.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly BasicDataContext _basicDataContext;

        public CompanyRepository(BasicDataContext basicDataContext)
        {
            _basicDataContext = basicDataContext;
        }

        public bool CompanyExists(int id)
        {
            return _basicDataContext.Companies.Any(c => c.CompanyId == id);
        }

        public ICollection<Company> GetCompanies()
        {
            return _basicDataContext.Companies.OrderBy(c => c.CompanyId).ToList();
        }

        public Company GetCompany(int id)
        {
            return _basicDataContext.Companies.Where(c => c.CompanyId == id).FirstOrDefault();
        }
        public void AddCompany(Company company)
        {
            _basicDataContext.Companies.Add(company);
            _basicDataContext.SaveChanges();
        }

        public void UpdateCompany(Company company)
        {
            _basicDataContext.Companies.Update(company);
            _basicDataContext.SaveChanges();
        }

        public void DeleteCompany(int id)
        {
            var company = GetCompany(id);
            if (company != null)
            {
                _basicDataContext.Companies.Remove(company);
                _basicDataContext.SaveChanges();
            }
        }
    }
}
