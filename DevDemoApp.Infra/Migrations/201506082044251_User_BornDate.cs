namespace DevDemoApp.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User_BornDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbUser", "BornDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbUser", "BornDate");
        }
    }
}
