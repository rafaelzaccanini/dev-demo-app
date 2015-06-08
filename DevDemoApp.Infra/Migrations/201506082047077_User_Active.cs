namespace DevDemoApp.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User_Active : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbUser", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbUser", "Active");
        }
    }
}
