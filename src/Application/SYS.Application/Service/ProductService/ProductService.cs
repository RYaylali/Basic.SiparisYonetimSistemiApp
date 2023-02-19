using AutoMapper;
using SYS.Application.Models.DTOs;
using SYS.Domain.Entities;
using SYS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.Service.ProductService
{
    public class ProductService :IProductService
    {
        private readonly IProductRepo _productRepo;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IProductRepo productRepo)
        {
            _mapper = mapper;
            _productRepo = productRepo;
        }
        public async Task<string> CreateCompany(AddProductDTO model)
        {
            var product = _mapper.Map<Product>(model);//modeldeki propertyleri companydeki propertylere eşitler.
            _productRepo.Add(product);
            if (_productRepo.Any(x => x.ID == product.ID))
                return "Product Succesfully Created";
            else
                return "Creating Product Failed";
        }
    }
}
