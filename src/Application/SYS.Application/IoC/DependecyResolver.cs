using Autofac;
using AutoMapper;
using SYS.Application.AutoMapper;
using SYS.Application.Service.CompanyService;
using SYS.Application.Service.OrderService;
using SYS.Application.Service.ProductService;
using SYS.Domain.Repositories;
using SYS.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.IoC
{
    public class DependecyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CompanyRepo>().As<ICompanyRepo>().InstancePerDependency();//Bağımlılığı azaltmak için kullanılır
            builder.RegisterType<OrderRepo>().As<IOrderRepo>().InstancePerDependency();
            builder.RegisterType<ProductRepo>().As<IProductRepo>().InstancePerDependency();
            builder.RegisterType<CompanyService>().As<ICompanyService>().InstancePerDependency();
            builder.RegisterType<OrderService>().As<IOrderService>().InstancePerDependency();
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerDependency();

            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Mapping>();
            }
            )).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            }).As<IMapper>().InstancePerLifetimeScope();
        }
        //her istek için yeni bir nesne örneği oluşturarak, nesne yaşam döngüsünün mümkün olan en düşük seviyede tutulmasını sağlayacaktır. Bu, gereksiz bellek kullanımını önleyerek performansı artırabilir.
    }
}
