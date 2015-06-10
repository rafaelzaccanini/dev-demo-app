using DevDemoApp.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DevDemoApp.Infra.Data.ORM.Configs
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            ToTable("tbUser");

            HasKey(x => x.CodUser);

            Property(x => x.CodUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                                    .IsRequired();

            Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();


        }
    }
}
