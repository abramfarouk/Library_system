namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteUserRoleTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserRoles", "RoleID", "Secuirty.Roles");
            DropForeignKey("dbo.UserRoles", "UserID", "Secuirty.Users");
            DropIndex("dbo.UserRoles", new[] { "RoleID" });
            DropIndex("dbo.UserRoles", new[] { "UserID" });
            AddColumn("Secuirty.Users", "Role_ID", c => c.Int());
            CreateIndex("Secuirty.Users", "Role_ID");
            AddForeignKey("Secuirty.Users", "Role_ID", "Secuirty.Roles", "ID");
            DropTable("dbo.UserRoles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("Secuirty.Users", "Role_ID", "Secuirty.Roles");
            DropIndex("Secuirty.Users", new[] { "Role_ID" });
            DropColumn("Secuirty.Users", "Role_ID");
            CreateIndex("dbo.UserRoles", "UserID");
            CreateIndex("dbo.UserRoles", "RoleID");
            AddForeignKey("dbo.UserRoles", "UserID", "Secuirty.Users", "ID", cascadeDelete: true);
            AddForeignKey("dbo.UserRoles", "RoleID", "Secuirty.Roles", "ID", cascadeDelete: true);
        }
    }
}
