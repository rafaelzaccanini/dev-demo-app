using DevDemoApp.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DevDemoApp.Infra.ORM.Configs
{
    public class UserGroupConfig : EntityTypeConfiguration<UserGroup>
    {
        public UserGroupConfig()
        {
            ToTable("tbUserGroup");

            HasKey(x => x.CodUserGroup);

            Property(x => x.CodUserGroup).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                                    .IsRequired();

            Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
