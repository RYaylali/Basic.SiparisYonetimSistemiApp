using Microsoft.EntityFrameworkCore;
using SYS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Infrastructure.Context
{
    public class SiparisYonetimSistemiDb:DbContext
    {
        public SiparisYonetimSistemiDb(DbContextOptions<SiparisYonetimSistemiDb> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-491CL38\\YAYLALISERVER22;database=SiparisYonetimDB;Trusted_Connection=True;");
        }
       
        public DbSet<Company> Companies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
