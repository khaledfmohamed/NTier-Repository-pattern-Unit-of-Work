namespace NTier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NTierModelsScrumContext : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.iterations", name: "Project_Id", newName: "Release_Id");
            RenameIndex(table: "dbo.iterations", name: "IX_Project_Id", newName: "IX_Release_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.iterations", name: "IX_Release_Id", newName: "IX_Project_Id");
            RenameColumn(table: "dbo.iterations", name: "Release_Id", newName: "Project_Id");
        }
    }
}
