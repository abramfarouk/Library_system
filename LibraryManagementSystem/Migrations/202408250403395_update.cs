namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RolesUsers", "Roles_ID", "Secuirty.Roles");
            DropForeignKey("dbo.RolesUsers", "User_ID", "Secuirty.Users");
            DropIndex("dbo.RolesUsers", new[] { "Roles_ID" });
            DropIndex("dbo.RolesUsers", new[] { "User_ID" });
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Secuirty.Roles", t => t.RoleID, cascadeDelete: true)
                .ForeignKey("Secuirty.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.RoleID)
                .Index(t => t.UserID);
            
            DropColumn("Secuirty.Roles", "ConCurrencyStamp");
            DropTable("dbo.RolesUsers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RolesUsers",
                c => new
                    {
                        Roles_ID = c.Int(nullable: false),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Roles_ID, t.User_ID });
            
            AddColumn("Secuirty.Roles", "ConCurrencyStamp", c => c.String());
            DropForeignKey("dbo.UserRoles", "UserID", "Secuirty.Users");
            DropForeignKey("dbo.UserRoles", "RoleID", "Secuirty.Roles");
            DropIndex("dbo.UserRoles", new[] { "UserID" });
            DropIndex("dbo.UserRoles", new[] { "RoleID" });
            DropTable("dbo.UserRoles");
            CreateIndex("dbo.RolesUsers", "User_ID");
            CreateIndex("dbo.RolesUsers", "Roles_ID");
            AddForeignKey("dbo.RolesUsers", "User_ID", "Secuirty.Users", "ID", cascadeDelete: true);
            AddForeignKey("dbo.RolesUsers", "Roles_ID", "Secuirty.Roles", "ID", cascadeDelete: true);
        }
    }
}
