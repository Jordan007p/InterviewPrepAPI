using Final.Models;

namespace Final.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        bool CountryExists(int id);
        Country AddCountry(Country country);
        Country UpdateCountry(Country country);
        void DeleteCountry(int id);
    }
}
