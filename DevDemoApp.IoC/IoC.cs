using DevDemoApp.Domain.Services;
using DevDemoApp.Domain.Contracts;
using DevDemoApp.Infra.Data;
using Ninject;

namespace DevDemoApp.Infra.IoC
{
    public static class IoC
    {
        public static StandardKernel CreateAndRegisterKernel()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IRepository>().To<Repository>();
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            
            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IServiceUser>().To<ServiceUser>();
            
            //kernel.Bind<RepositorioFactories>().To<RepositorioFactories>()
            //    .InSingletonScope();

            return kernel;
        }
    }
}
