namespace DevDemoApp.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDataAndTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbUserGroup",
                c => new
                    {
                        CodUserGroup = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CodUserGroup);
            
            CreateTable(
                "dbo.tbUser",
                c => new
                    {
                        CodUser = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        CodUserGroup = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CodUser)
                .ForeignKey("dbo.tbUserGroup", t => t.CodUserGroup, cascadeDelete: true)
                .Index(t => t.CodUserGroup);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbUser", "CodUserGroup", "dbo.tbUserGroup");
            DropIndex("dbo.tbUser", new[] { "CodUserGroup" });
            DropTable("dbo.tbUser");
            DropTable("dbo.tbUserGroup");
        }
    }
}
