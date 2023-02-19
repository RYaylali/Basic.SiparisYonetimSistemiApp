using Microsoft.EntityFrameworkCore;
using SYS.Infrastructure.Context;
using Newtonsoft.Json;
using SYS.Application.Service.CompanyService;
using SYS.Application.Service.OrderService;
using SYS.Application.Service.ProductService;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using SYS.Application.IoC;

namespace SYS.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddNewtonsoftJson(option =>
            option.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<SiparisYonetimSistemiDb>(option =>
            {
                option.UseSqlServer("server=DESKTOP-491CL38\\YAYLALISERVER22;database=SiparisYonetimDB;Trusted_Connection=True;");
            });
            builder.Services.AddTransient<ICompanyService, CompanyService>();
            builder.Services.AddTransient<IOrderService, OrderService>();
            builder.Services.AddTransient<IProductService, ProductService>();
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

            builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterModule(new DependecyResolver());
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run();
        }
    }
}