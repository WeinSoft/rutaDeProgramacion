namespace WebAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gatoscreatetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gatoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Raza = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Gatoes");
        }
    }
}
