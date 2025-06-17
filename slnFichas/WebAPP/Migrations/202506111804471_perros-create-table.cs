namespace WebAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class perroscreatetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Perros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Raza = c.String(),
                        Peso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaAdd = c.DateTime(nullable: false),
                        FechaUpdate = c.DateTime(nullable: false),
                        FechaDelete = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Perros");
        }
    }
}
