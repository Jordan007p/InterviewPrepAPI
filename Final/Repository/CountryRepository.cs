using Final.Data;
using Final.Interfaces;
using Final.Models;

namespace Final.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly BasicDataContext _basicDataContext;

        public CountryRepository(BasicDataContext basicDataContext)
        {
            _basicDataContext = basicDataContext;
        }

        public bool CountryExists(int id)
        {
            return _basicDataContext.Countries.Any(c => c.CountryId == id);
        }

        public ICollection<Country> GetCountries()
        {
            return _basicDataContext.Countries.OrderBy(c => c.CountryId).ToList();
        }

        public Country GetCountry(int id)
        {
            return _basicDataContext.Countries.Where(c => c.CountryId == id).FirstOrDefault();
        }

        public Country AddCountry(Country country)
        {
            _basicDataContext.Countries.Add(country);
            _basicDataContext.SaveChanges();
            return country;
        }

        public Country UpdateCountry(Country country)
        {
            var existingCountry = _basicDataContext.Countries.FirstOrDefault(c => c.CountryId == country.CountryId);
            if (existingCountry != null)
            {
                existingCountry.CountryName = country.CountryName;

                _basicDataContext.SaveChanges();
            }
            return existingCountry;
        }

        public void DeleteCountry(int id)
        {
            var country = _basicDataContext.Countries.FirstOrDefault(c => c.CountryId == id);
            if (country != null)
            {
                _basicDataContext.Countries.Remove(country);
                _basicDataContext.SaveChanges();
            }
        }



    }
}
