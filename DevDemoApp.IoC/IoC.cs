using DevDemoApp.Domain;
using DevDemoApp.Domain.Services.Base;
using Microsoft.Practices.Unity;
using DevDemoApp.Domain.Contracts;
using DevDemoApp.Infra;
using DevDemoApp.Infra.Repositories;

namespace DevDemoApp.IoC
{
    /// <summary>
    /// Class to manage the container of IoC
    /// </summary>
    public static class IoC
    {
        public static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // Domain Layer
            container.RegisterType(typeof(IServiceBase<User>), typeof(ServiceBase<User>));
            container.RegisterType(typeof(IServiceUser), typeof(ServiceUser));

            // Infra Data Layer
            container.RegisterType(typeof(IRepository<User>), typeof(Repository<User>));
            container.RegisterType(typeof(IRepositoryUser), typeof(RepositoryUser));

            return container;
        }
    }
}
