using AutoMapper;
using HR.Application.Models.DTOs;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SYS.Domain.Entities;
using SYS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.Service.CompanyService
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepo _companyRepo;
        private readonly IMapper _mapper;

        public CompanyService(IMapper mapper, ICompanyRepo companyRepo)
        {
            _mapper = mapper;
            _companyRepo = companyRepo;
        }

        public async Task<string> CreateCompany(AddCompanyDTO companyDto)
        {
            var company = _mapper.Map<Company>(companyDto);
            _companyRepo.Add(company);
            return "Company Succesfully Created";
        }

        public  string UpdateCompany(Company model)
        {
            try
            {
               Company company= _companyRepo.GetById(model.ID);

                if (company!=null)
                {
                     _companyRepo.Update(company);
                  
                }
            }
            catch (Exception)
            {

                return "Could not updated";
            }
            return "Successfully updated";
        }
        public List<Company> GetAllCampany()
        {
            return _companyRepo.GetAll();
        }
    }
}
