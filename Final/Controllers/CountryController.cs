using AutoMapper;
using Final.Dto;
using Final.Interfaces;
using Final.Models;
using Final.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public CountryController(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<CountryDto>))]
        public IActionResult GetCompanies()
        {
            var countries = _mapper.Map<List<CountryDto>>(_countryRepository.GetCountries());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(countries);
        }

        [HttpGet("{countryId}")]
        [ProducesResponseType(200, Type = typeof(CountryDto))]
        [ProducesResponseType(400)]
        public IActionResult GetCountry(int countryId)
        {
            if (!_countryRepository.CountryExists(countryId))
            {
                return NotFound(ModelState);
            }
            var company = _mapper.Map<CountryDto>(_countryRepository.GetCountry(countryId));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(company);
        }

        [HttpPost]
        public IActionResult AddCountry([FromBody] CountryDto countryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var country = _mapper.Map<Country>(countryDto);
            var newCountry = _countryRepository.AddCountry(country);
            var newCountryDto = _mapper.Map<CountryDto>(newCountry);

            return CreatedAtAction(nameof(GetCountry), new { countryId = newCountry.CountryId }, newCountryDto);
        }
        [HttpPut("{countryId}")]
        public IActionResult UpdateCountry(int countryId, [FromBody] CountryDto countryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (countryId != countryDto.CountryId)
            {
                return BadRequest("Mismatch between route ID and country ID.");
            }

            if (!_countryRepository.CountryExists(countryId))
            {
                return NotFound();
            }

            var countryToUpdate = _mapper.Map<Country>(countryDto);
            var updatedCountry = _countryRepository.UpdateCountry(countryToUpdate);
            var updatedCountryDto = _mapper.Map<CountryDto>(updatedCountry);

            return Ok(updatedCountryDto);
        }

        [HttpDelete("{countryId}")]
        public IActionResult DeleteCountry(int countryId)
        {
            if (!_countryRepository.CountryExists(countryId))
            {
                return NotFound();
            }

            _countryRepository.DeleteCountry(countryId);
            return NoContent();
        }


    }
}
