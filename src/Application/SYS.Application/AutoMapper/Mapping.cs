using AutoMapper;
using HR.Application.Models.DTOs;
using SYS.Application.Models.DTOs;
using SYS.Application.Models.VMs;
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
        public Mapping()//DTO VE VMLERİ CLASSDAKİ PROPERTYLERİ İLE EŞLEMEYİ SAĞLAR
        {
            CreateMap<Company, AddCompanyDTO>().ReverseMap();
            CreateMap<Company, UpdateCompanyDTO>().ReverseMap();
            CreateMap<Company, ListOfCompanyVM>().ReverseMap();
            CreateMap<Order, AddOrderDTO>().ReverseMap();
            CreateMap<Product, AddProductDTO>().ReverseMap();
        }
    }
}
