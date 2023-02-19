using HR.Application.Models.DTOs;
using SYS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.Service.CompanyService
{
    public interface ICompanyService
    {
        Task<string> CreateCompany(AddCompanyDTO model);
        string UpdateCompany(Company model);
        List<Company> GetAllCampany();
    }
}
