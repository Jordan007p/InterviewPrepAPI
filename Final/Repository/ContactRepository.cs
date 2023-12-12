using Final.Data;
using Final.Dto;
using Final.Interfaces;
using Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Final.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly BasicDataContext _basicDataContext;

        public ContactRepository(BasicDataContext basicDataContext)
        {
            _basicDataContext = basicDataContext;
        }

        public bool ContactExists(int id)
        {
            return _basicDataContext.Contacts.Any(c => c.ContactId == id);
        }

        public Contact GetContact(int id)
        {
            return _basicDataContext.Contacts.Where(c => c.ContactId == id).FirstOrDefault();
        }

        public ICollection<Contact> GetContacts()
        {
            return _basicDataContext.Contacts.OrderBy(c => c.ContactId).ToList();
        }

        public ICollection<ContactDetailsDto> GetContactsWithDetails()
        {
            var contacts = _basicDataContext.Contacts
                .Include(c => c.Company)
                .Include(c => c.Country)
                .OrderBy(c => c.ContactId)
                .ToList();

            var contactDetails = contacts.Select(c => new ContactDetailsDto
            {
                ContactId = c.ContactId,
                ContactName = c.ContactName,
                CompanyName = c.Company.CompanyName,
                CountryName = c.Country.CountryName
            }).ToList();

            return contactDetails;
        }

        public ICollection<Contact> FilterContacts(int? countryId, int? companyId)
        {
            var query = _basicDataContext.Contacts.AsQueryable();

            if (countryId.HasValue)
            {
                query = query.Where(c => c.CountryId == countryId.Value);
            }


            if (companyId.HasValue)
            {
                query = query.Where(c => c.CompanyId == companyId.Value);
            }

            return query.OrderBy(c => c.ContactId).ToList();
        }

        public Contact AddContact(Contact contact)
        {
            _basicDataContext.Contacts.Add(contact);
            _basicDataContext.SaveChanges();
            return contact;
        }

        public Contact UpdateContact(Contact contact)
        {
            var existingContact = _basicDataContext.Contacts.FirstOrDefault(c => c.ContactId == contact.ContactId);
            if (existingContact != null)
            {
                existingContact.ContactName = contact.ContactName;
                existingContact.CompanyId = contact.CompanyId;
                existingContact.CountryId = contact.CountryId;

                _basicDataContext.SaveChanges();
            }
            return existingContact;
        }

        public void DeleteContact(int id)
        {
            var contact = _basicDataContext.Contacts.FirstOrDefault(c => c.ContactId == id);
            if (contact != null)
            {
                _basicDataContext.Contacts.Remove(contact);
                _basicDataContext.SaveChanges();
            }
        }

    }
}
