using SYS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.Models.DTOs
{
    public class UpdateCompanyDTO
    {
        public Guid ID { get; set; }
        public ApprovalStatus? ApprovalStatus { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime? UpdatedDate => DateTime.Now;
    }
}

