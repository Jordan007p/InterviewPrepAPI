using Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Final.Seeds
{
    public static class InitialSeed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            SeedCompanies(modelBuilder);
            SeedCountries(modelBuilder);
            SeedContacts(modelBuilder);
        }

        private static void SeedCompanies(ModelBuilder modelBuilder)
        {
            var companies = new List<Company>
        {
            new Company { CompanyId = 1, CompanyName = "Company 1" },
            new Company { CompanyId = 2, CompanyName = "Company 2" },
            new Company { CompanyId = 3, CompanyName = "Company 3" },
            new Company { CompanyId = 4, CompanyName = "Company 4" },
            new Company { CompanyId = 5, CompanyName = "Company 5" },
            new Company { CompanyId = 6, CompanyName = "Company 6" },
            new Company { CompanyId = 7, CompanyName = "Company 7" },
            new Company { CompanyId = 8, CompanyName = "Company 8" },
            new Company { CompanyId = 9, CompanyName = "Company 9" },
            new Company { CompanyId = 10, CompanyName = "Company 10" }
        };
            modelBuilder.Entity<Company>().HasData(companies);
        }

        private static void SeedCountries(ModelBuilder modelBuilder)
        {
            var countries = new List<Country>
        {
            new Country { CountryId = 1, CountryName = "Country 1" },
            new Country { CountryId = 2, CountryName = "Country 2" },
            new Country { CountryId = 3, CountryName = "Country 3" },
            new Country { CountryId = 4, CountryName = "Country 4" },
            new Country { CountryId = 5, CountryName = "Country 5" },
            new Country { CountryId = 6, CountryName = "Country 6" },
            new Country { CountryId = 7, CountryName = "Country 7" },
            new Country { CountryId = 8, CountryName = "Country 8" },
            new Country { CountryId = 9, CountryName = "Country 9" },
            new Country { CountryId = 10, CountryName = "Country 10" }
        };
            modelBuilder.Entity<Country>().HasData(countries);
        }

        private static void SeedContacts(ModelBuilder modelBuilder)
        {
            var contacts = new List<Contact>
        {
            new Contact { ContactId = 1, ContactName = "Contact 1", CompanyId = 1, CountryId = 1 },
            new Contact { ContactId = 2, ContactName = "Contact 2", CompanyId = 2, CountryId = 2 },
            new Contact { ContactId = 3, ContactName = "Contact 3", CompanyId = 3, CountryId = 3 },
            new Contact { ContactId = 4, ContactName = "Contact 4", CompanyId = 4, CountryId = 4 },
            new Contact { ContactId = 5, ContactName = "Contact 5", CompanyId = 5, CountryId = 5 },
            new Contact { ContactId = 6, ContactName = "Contact 6", CompanyId = 6, CountryId = 6 },
            new Contact { ContactId = 7, ContactName = "Contact 7", CompanyId = 7, CountryId = 7 },
            new Contact { ContactId = 8, ContactName = "Contact 8", CompanyId = 8, CountryId = 8 },
            new Contact { ContactId = 9, ContactName = "Contact 9", CompanyId = 9, CountryId = 9 },
            new Contact { ContactId = 10, ContactName = "Contact 10", CompanyId = 10, CountryId = 10 }
        };
            modelBuilder.Entity<Contact>().HasData(contacts);
        }
    }
}
