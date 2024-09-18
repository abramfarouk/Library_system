namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedRolesAndUsers : DbMigration
    {
        public override void Up( )
        {
            Sql(@"INSERT INTO [Secuirty].[Roles] (Name, NormalizedName) 
              VALUES ('User', 'USER' )");

            Sql(@"INSERT INTO [Secuirty].[Roles] (Name, NormalizedName) 
              VALUES ('Admin', 'ADMIN')");
        }
        
        public override void Down()
        {

            Sql("DELETE FROM [Secuirty].[Roles] WHERE Name IN ('User', 'Admin')");

        }
    }
}
