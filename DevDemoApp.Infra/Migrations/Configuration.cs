namespace DevDemoApp.Infra.Data.Migrations
{
    using DevDemoApp.Domain;
    using System.Data.Entity.Migrations;
    using DevDemoApp.Infra.Data.Context;

    internal sealed class Configuration : DbMigrationsConfiguration<DevDemoAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DevDemoAppContext context)
        {
            //context.UserGroups.AddOrUpdate(x => x.CodUserGroup,
            //    new UserGroup() { CodUserGroup = 1, Name = "Group 1", Active = true }
            //);

            //context.Users.AddOrUpdate(x => x.CodUser,
            //    new User() { CodUser = 1, Name = "Zaccanini", CodUserGroup = 1 },
            //    new User() { CodUser = 2, Name = "Miguel", CodUserGroup = 1 }
            //);
        }
    }
}
