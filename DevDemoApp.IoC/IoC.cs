using DevDemoApp.Domain.Services;
using DevDemoApp.Domain.Contracts;
using DevDemoApp.Infra.Data;
using Ninject;
using DevDemoApp.Application;

namespace DevDemoApp.Infra.IoC
{
    public static class IoC
    {
        public static StandardKernel CreateAndRegisterKernel()
        {
            var kernel = new StandardKernel();

            // Repository
            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));

            // Domain Services
            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IServiceUser>().To<ServiceUser>();
            kernel.Bind<IServiceUserGroup>().To<ServiceUserGroup>();

            // Application Services
            kernel.Bind<IApplicationServiceAccount>().To<ApplicationServiceAccount>();

            return kernel;
        }
    }
}
