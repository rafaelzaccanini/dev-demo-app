namespace DevDemoApp.Domain.Services
{
    public interface IServiceUserGroup : IServiceBase<UserGroup>
    {
        UserGroup Get(int cod);
    }
}
