using Final.Dto;
using Final.Models;

namespace Final.Interfaces
{
    public interface IContactRepository
    {
        ICollection<Contact> GetContacts();
        Contact GetContact(int id);
        bool ContactExists(int id);
        ICollection<ContactDetailsDto> GetContactsWithDetails();
        ICollection<Contact> FilterContacts(int? countryId, int? companyId);
        Contact AddContact(Contact contact);
        Contact UpdateContact(Contact contact);
        void DeleteContact(int id);
    }
}
