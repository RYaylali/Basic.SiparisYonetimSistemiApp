using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SYS.Application.Models.DTOs;
using SYS.Application.Service.CompanyService;
using SYS.Application.Service.ProductService;
using SYS.Domain.Entities;

namespace SYS.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public ActionResult CreateProduct(AddProductDTO product)
        {
            var success = _productService.CreateCompany(product);
            if (success == null)
            {
                return BadRequest("Invalid data");//Geçersiz veri
            }
            return Ok(product);
        }
    }
}
