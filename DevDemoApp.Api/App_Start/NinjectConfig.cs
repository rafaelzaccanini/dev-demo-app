using DevDemoApp.Api.Help.Ninject;
using System.Web.Http;
using DevDemoApp.Infra.IoC;

namespace DevDemoApp.Api
{
    public class NinjectConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.DependencyResolver = new NinjectDependencyResolver(IoC.CreateAndRegisterKernel());
        }
    }
}