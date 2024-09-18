namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeImageUrlFromBookTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "image", c => c.String());
        }
    }
}
