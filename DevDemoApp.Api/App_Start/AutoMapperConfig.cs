using DevDemoApp.Application.AutoMapper;

namespace DevDemoApp.Api
{
    public class AutoMapperConfig
    {
        public static void Register()
        {
            AutoMapperConfigs.Make();
        }
    }
}