using SYS.Application.Models.DTOs;
using SYS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.Service.ProductService
{
    public interface IProductService
    {
        Task<string> CreateCompany(AddProductDTO model);
    }
}
