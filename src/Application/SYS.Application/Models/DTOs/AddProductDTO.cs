using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.Models.DTOs
{
    public class AddProductDTO
    {
        public string ProductName { get; set; }
        public short? Quantity { get; set; }//Ürün stokta olmayabilir
        public decimal Price { get; set; }
        public Guid? CompanyID { get; set; }
    }
}
