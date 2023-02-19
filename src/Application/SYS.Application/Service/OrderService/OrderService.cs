using AutoMapper;
using SYS.Domain.Entities;
using SYS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.Service.OrderService
{
    public class OrderService :IOrderService
    {
        private readonly IOrderRepo _orderRepo;
        private readonly IMapper _mapper;

        public OrderService(IMapper mapper, IOrderRepo orderRepo)
        {
            _mapper = mapper;
            _orderRepo = orderRepo;
        }
        public async Task<string> CreateCompany(Order model)
        {
            var order = _mapper.Map<Order>(model);//modeldeki propertyleri orderdeki propertylere eşitler.
            DateTime now = DateTime.Now;
            long time = new DateTimeOffset(now).ToUnixTimeSeconds();
               
            //if (model.Company.StartTime >= time && model.Company.EndTime <= time)
            //{
                _orderRepo.Add(order);
                return "Product Succesfully Created";
            //}
            //else
            //{
            //    return $"Orders cannot be taken at {DateTime.Now.Hour}:{DateTime.Now.Minute}";//zamann aralığı uygun değildir
            //}   
                
        }
    }
}
