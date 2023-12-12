using AutoMapper;
using Final.Dto;
using Final.Interfaces;
using Final.Models;
using Final.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;

        public ContactController(IContactRepository companyRepository, IMapper mapper)
        {
            _contactRepository = companyRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<ContactDto>))]
        public IActionResult GetContacts()
        {
            var contacts = _mapper.Map<List<ContactDto>>(_contactRepository.GetContacts());
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(contacts);
        }

        [HttpGet("{contactId}")]
        [ProducesResponseType(200, Type = typeof(ContactDto))]
        [ProducesResponseType(400)]
        public IActionResult GetContact(int contactId)
        {
            if (!_contactRepository.ContactExists(contactId))
            {
                return NotFound(ModelState);
            }
            var company = _mapper.Map<ContactDto>(_contactRepository.GetContact(contactId));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(company);
        }

        [HttpGet("details")]
        [ProducesResponseType(200, Type = typeof(ICollection<ContactDetailsDto>))]
        public IActionResult GetContactsWithDetails()
        {
            var contactDetails = _contactRepository.GetContactsWithDetails();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(contactDetails);
        }

        [HttpGet("filter")]
        [ProducesResponseType(200, Type = typeof(ICollection<ContactDto>))]
        public IActionResult FilterContacts(int? countryId, int? companyId)
        {
            var filteredContacts = _mapper.Map<List<ContactDto>>(_contactRepository.FilterContacts(countryId, companyId));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(filteredContacts);
        }

        [HttpPost]
        public IActionResult AddContact([FromBody] ContactDto contactDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var contact = _mapper.Map<Contact>(contactDto);

            var newContact = _contactRepository.AddContact(contact);

            var newContactDto = _mapper.Map<ContactDto>(newContact);

            return CreatedAtAction(nameof(GetContact), new { contactId = newContact.ContactId }, newContactDto);
        }



        [HttpPut("{contactId}")]
        public IActionResult UpdateContact(int contactId, [FromBody] ContactDto contactDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (contactId != contactDto.ContactId)
            {
                return BadRequest("Mismatch between route ID and contact ID.");
            }

            if (!_contactRepository.ContactExists(contactId))
            {
                return NotFound();
            }

            var contactToUpdate = _mapper.Map<Contact>(contactDto);
            var updatedContact = _contactRepository.UpdateContact(contactToUpdate);

            var updatedContactDto = _mapper.Map<ContactDto>(updatedContact);

            return Ok(updatedContactDto);
        }



        [HttpDelete("{contactId}")]
        public IActionResult DeleteContact(int contactId)
        {
            if (!_contactRepository.ContactExists(contactId))
            {
                return NotFound();
            }

            _contactRepository.DeleteContact(contactId);
            return NoContent();
        }


    }
}
