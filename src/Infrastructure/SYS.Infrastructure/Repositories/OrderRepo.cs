using SYS.Domain.Entities;
using SYS.Domain.Repositories;
using SYS.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Infrastructure.Repositories
{
    public class OrderRepo : BaseRepo<Order>, IOrderRepo
    {
        public OrderRepo(SiparisYonetimSistemiDb context) : base(context)
        {
        }
    }
}
