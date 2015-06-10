using DevDemoApp.Domain.Services;
using DevDemoApp.Domain.Contracts;
using DevDemoApp.Infra.Data;
using Ninject;
using DevDemoApp.Domain;

namespace DevDemoApp.Infra.IoC
{
    public static class IoC
    {
        public static StandardKernel CreateAndRegisterKernel()
        {
            var kernel = new StandardKernel();

            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));

            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            kernel.Bind<IServiceUser>().To<ServiceUser>();
            
            //kernel.Bind<RepositorioFactories>().To<RepositorioFactories>()
            //    .InSingletonScope();

            return kernel;
        }
    }
}
