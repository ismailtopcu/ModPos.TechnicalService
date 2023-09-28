using Autofac;
using ModPos.TechnicalService.BusinessLayer.Abstract;
using ModPos.TechnicalService.BusinessLayer.Concrete;
using ModPos.TechnicalService.DataAccessLayer.Abstract;
using ModPos.TechnicalService.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModPos.TechnicalService.BusinessLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerManager>().As<ICustomerService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().InstancePerLifetimeScope();

            builder.RegisterType<ProductManager>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<EfProductDal>().As<IProductDal>().InstancePerLifetimeScope();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().InstancePerLifetimeScope();

            builder.RegisterType<ServiceManager>().As<IServiceService>().InstancePerLifetimeScope();
            builder.RegisterType<EfServiceDal>().As<IServiceDal>().InstancePerLifetimeScope();

            builder.RegisterType<ServiceMovementsManager>().As<IServiceMovementsService>().InstancePerLifetimeScope();
            builder.RegisterType<EfServiceMovementsDal>().As<IServiceMovementsDal>().InstancePerLifetimeScope();
        }
    }
}
