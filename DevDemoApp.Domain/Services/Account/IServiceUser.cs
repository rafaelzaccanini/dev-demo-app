namespace DevDemoApp.Domain.Services
{
    public interface IServiceUser : IServiceBase<User>
    {
        User Get(int cod);
    }
}
