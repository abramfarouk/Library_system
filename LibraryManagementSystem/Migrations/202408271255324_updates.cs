namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Description", c => c.String(nullable: false));
            AddColumn("dbo.BorrowedBooks", "IsReturn", c => c.Boolean(nullable: false));
            AddColumn("dbo.People", "BlackList", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "BlackList");
            DropColumn("dbo.BorrowedBooks", "IsReturn");
            DropColumn("dbo.Books", "Description");
        }
    }
}
