namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Roles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NormalizedName = c.String(),
                        ConCurrencyStamp = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RolesUsers",
                c => new
                    {
                        Roles_ID = c.Int(nullable: false),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Roles_ID, t.User_ID })
                .ForeignKey("dbo.Roles", t => t.Roles_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .Index(t => t.Roles_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolesUsers", "User_ID", "dbo.Users");
            DropForeignKey("dbo.RolesUsers", "Roles_ID", "dbo.Roles");
            DropIndex("dbo.RolesUsers", new[] { "User_ID" });
            DropIndex("dbo.RolesUsers", new[] { "Roles_ID" });
            DropTable("dbo.RolesUsers");
            DropTable("dbo.Roles");
        }
    }
}
