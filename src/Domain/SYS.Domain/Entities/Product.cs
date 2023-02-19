using SYS.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Domain.Entities
{
    public class Product :BaseEntity
    {
        public string ProductName { get; set; }
        public short? Quantity { get; set; }//Ürün stokta olmayabilir
        public decimal Price { get; set; }
        //Navigation Properties
        //bir ürünü bir şirket alabilir
        public Guid CompanyID { get; set; }
        public virtual Company Company { get; set; }
        //bir ürün birden fazla siparişte olabilir
        public virtual List<Order> Orders { get; set; }

}
}
