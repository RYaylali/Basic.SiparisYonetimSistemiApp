using AutoMapper;
using SYS.Application.Models.DTOs;
using SYS.Domain.Entities;
using SYS.Domain.Enums;
using SYS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.Service.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepo _orderRepo;
        private readonly IProductRepo _productRepo;
        private readonly ICompanyRepo _companyRepo;
        private readonly IMapper _mapper;

        public OrderService(IMapper mapper, IOrderRepo orderRepo, IProductRepo productRepo, ICompanyRepo companyRepo)
        {
            _mapper = mapper;
            _orderRepo = orderRepo;
            _productRepo = productRepo;
            _companyRepo = companyRepo;
        }
        public async Task<string> CreateCompany(AddOrderDTO model)
        {
            var order = _mapper.Map<Order>(model);//modeldeki propertyleri orderdeki propertylere eşitler.
            Product product = _productRepo.GetById(model.ProductID);
            Company company = _companyRepo.GetById(product.CompanyID);
            TimeSpan time = DateTime.Now.TimeOfDay;

            if (company.StartTime <= time && company.EndTime >= time && company.ApprovalStatus==ApprovalStatus.approved)
            {
                _orderRepo.Add(order);
                return "Product Succesfully Created";
            }
            else
            {
                if (company.ApprovalStatus != ApprovalStatus.approved)
                {
                    return $"could not be created because company status is {company.ApprovalStatus}";
                }
                return $"Orders cannot be taken at {DateTime.Now.Hour}:{DateTime.Now.Minute}";//zamann aralığı uygun değildir
            }


        }
    }
}
