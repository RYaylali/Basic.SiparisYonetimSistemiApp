using SYS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }//Güncelleme yapılmayabilir o yüzden null geçirilebilir
        public DateTime? DeletedDate { get; set; }//Silinmeyebilir o yüzden null geçirilebilir
        public Status Status { get; set; }
    }
}
