namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameSchemaAndTables : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Users", newSchema: "Secuirty");
            MoveTable(name: "dbo.Roles", newSchema: "Secuirty");
        }
        
        public override void Down()
        {
            MoveTable(name: "Secuirty.Roles", newSchema: "dbo");
            MoveTable(name: "Secuirty.Users", newSchema: "dbo");
        }
    }
}
