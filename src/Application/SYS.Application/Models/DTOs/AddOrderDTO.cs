
using SYS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.Models.DTOs
{
    public class AddOrderDTO
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate =>DateTime.Now;//sipariş verildiğinde direk zaman ataması için
        public Guid ProductID { get; set; }//FORENGY KEY
       
        

    }
}
