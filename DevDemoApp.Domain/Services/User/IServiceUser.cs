
namespace DevDemoApp.Domain.Services
{
    public interface IServiceUser : IServiceBase<User>
    {
        User FindByCod(int cod);
    }
}
