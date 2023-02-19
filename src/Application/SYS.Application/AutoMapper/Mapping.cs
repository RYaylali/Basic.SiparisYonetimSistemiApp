using AutoMapper;
using HR.Application.Models.DTOs;
using SYS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Company, AddCompanyDTO>().ReverseMap();
        }
    }
}
