using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using IoC = DevDemoApp.IoC;

namespace DevDemoApp.Api
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterComponents()
        {
            var container = IoC.IoC.BuildUnityContainer();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            
            return container;
        }
    }
}