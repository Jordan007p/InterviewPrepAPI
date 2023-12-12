using AutoMapper;
using Final.Dto;
using Final.Interfaces;
using Final.Models;
using Final.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyController(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<CompanyDto>))]
        public IActionResult GetCompanies()
        {
            var companies = _mapper.Map<List<CompanyDto>>(_companyRepository.GetCompanies());
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(companies);
        }

        [HttpGet("{companyId}")]
        [ProducesResponseType(200, Type = typeof(CompanyDto))]
        [ProducesResponseType(400)]
        public IActionResult GetCompany(int companyId)
        {
            if (!_companyRepository.CompanyExists(companyId))
            {
                return NotFound(ModelState);
            }
            var company = _mapper.Map<CompanyDto>(_companyRepository.GetCompany(companyId));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(company);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateCompany([FromBody] CompanyDto companyDto)
        {
            if (companyDto == null)
            {
                return BadRequest(ModelState);
            }

            var company = _mapper.Map<Company>(companyDto);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _companyRepository.AddCompany(company);
            return StatusCode(201);
        }


        [HttpPut("{companyId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult UpdateCompany(int companyId, [FromBody] CompanyDto companyDto)
        {
            if (companyDto == null || companyId != companyDto.CompanyId)
            {
                return BadRequest(ModelState);
            }

            if (!_companyRepository.CompanyExists(companyId))
            {
                return NotFound();
            }

            var company = _mapper.Map<Company>(companyDto);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _companyRepository.UpdateCompany(company);
            return NoContent();
        }

        [HttpDelete("{companyId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult DeleteCompany(int companyId)
        {
            if (!_companyRepository.CompanyExists(companyId))
            {
                return NotFound();
            }

            _companyRepository.DeleteCompany(companyId);
            return NoContent();
        }


    }
}
