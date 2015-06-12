namespace DevDemoApp.Application
{
    public class UserDTO
    {
        public int CodUser { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public UserGroupDTO UserGroup { get; set; }
    }
}
