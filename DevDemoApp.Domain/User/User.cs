using System;
namespace DevDemoApp.Domain
{
    public class User
    {
        public int CodUser { get; set; }

        public string Name { get; set; }

        public int CodUserGroup { get; set; }

        public DateTime BornDate { get; set; }

        public bool Active { get; set; }

        public virtual UserGroup UserGroup { get; set; }
    }
}
