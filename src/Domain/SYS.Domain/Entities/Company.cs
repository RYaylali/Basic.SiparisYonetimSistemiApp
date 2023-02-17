using SYS.Domain.Entities.Common;
using SYS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        //Navigation Properties
        //Bİr Şirket birden fazla sipariş verebilir
        //Bir şirket birden fazla ürün alabilir 
        public virtual List<Order> Orders { get; set; }//+
        public virtual List<Product> Products { get; set; }//+
    }
}
