using SYS.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Domain.Entities
{
    public class Order :BaseEntity
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        //Navigation Property
        //bir ürün siparişte tek birkez verilir
        public  Guid? ProductID { get; set; }//FORENGY KEY
        public virtual Product? Product { get; set; }
        //bir siparişi bir şirket verebilir
        public Guid? CompanyID { get; set; }//FORENGY KEY
        public virtual Company? Company { get; set; }

    }
}
