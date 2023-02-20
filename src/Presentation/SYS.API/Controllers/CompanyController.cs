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
            var result = _companyService.GetAllCampany();
            if (result == null)
            {
                return StatusCode(500, "Server error");//Sunucu Hatası
            }
            return Ok(result);
        }
        [HttpPost]
        public ActionResult CreateCompany(AddCompanyDTO companyDto)
        {
            var success = _companyService.CreateCompany(companyDto);
            if (success==null)
            {
                return BadRequest("Invalid data");//geçersiz veri
            }
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
