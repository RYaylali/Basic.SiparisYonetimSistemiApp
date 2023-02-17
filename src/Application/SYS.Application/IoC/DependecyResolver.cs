using Autofac;
using AutoMapper;
using SYS.Application.AutoMapper;
using SYS.Domain.Repositories;
using SYS.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application.IoC
{
    public class DependecyResolver :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CompanyRepo>().As<ICompanyRepo>().InstancePerLifetimeScope();//Bağımlılığı azaltmak için kullanılır
            builder.RegisterType<OrderRepo>().As<IOrderRepo>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepo>().As<IProductRepo>().InstancePerLifetimeScope();

            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Mapping>();
            }
           )).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                //daha sonra kullanılabilecek yeni bağlamlar için
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();

                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();
            base.Load(builder);
        }

    }
}
