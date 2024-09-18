namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookTitle = c.String(nullable: false, maxLength: 25),
                        Author = c.String(nullable: false, maxLength: 25),
                        Published = c.DateTime(nullable: false),
                        image = c.String(),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BorrowedBooks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                        StartBorrow = c.DateTime(nullable: false),
                        EndBoorow = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Address = c.String(nullable: false, maxLength: 25),
                        phone = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BorrowedBooks", "PersonId", "dbo.People");
            DropForeignKey("dbo.BorrowedBooks", "BookId", "dbo.Books");
            DropIndex("dbo.BorrowedBooks", new[] { "PersonId" });
            DropIndex("dbo.BorrowedBooks", new[] { "BookId" });
            DropTable("dbo.People");
            DropTable("dbo.BorrowedBooks");
            DropTable("dbo.Books");
        }
    }
}
