using System.Collections.Generic;

namespace DevDemoApp.Domain
{
    public class UserGroup
    {
        public int CodUserGroup { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
