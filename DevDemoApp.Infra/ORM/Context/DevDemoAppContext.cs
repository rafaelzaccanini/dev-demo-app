using DevDemoApp.Domain;
using DevDemoApp.Infra.ORM.Configs;
using System.Data.Entity;

namespace DevDemoApp.Infra.Context
{
    public class DevDemoAppContext : DbContext
    {
        public DevDemoAppContext() :
            base("DevDemoAppConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new UserGroupConfig());
        }
    }
}
