using Autofac.Core;
using HR.Application.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SYS.Application.Models.DTOs;
using SYS.Application.Service.CompanyService;
using SYS.Domain.Entities;

namespace SYS.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;


        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public ActionResult GetAllCompany()
        {
            return Ok(_companyService.GetAllCampany());
        }
        [HttpPost]//Ekleme işleminde post kullanılır
        public ActionResult CreateCompany(AddCompanyDTO companyDto)
        {
            _companyService.CreateCompany(companyDto);
            return Ok(companyDto);
        }
        [HttpPut]//güncelleme işlemlerinde kullanılır
        public ActionResult UpdateCompany(Guid id,UpdateCompanyDTO company) 
        {
            if (id != company.ID)
            {
                return BadRequest();
            }
            try
            {
                _companyService.UpdateCompany(company);
                return Ok(company);
            }
            catch (Exception)
            {

                return NoContent();
            }
        }
        //private bool HaveCompany(Guid id)//şirketin olup olmadığığı kontrol etmek için metot. yok ise ona göre hata mesajı dönecek. Bunu repoyu eklersem yapabilirim
        //{
        //    return _companyService.Any(x => x.Id == id);//idleri karşılaştırmak için metot 
        //}
    }
}
