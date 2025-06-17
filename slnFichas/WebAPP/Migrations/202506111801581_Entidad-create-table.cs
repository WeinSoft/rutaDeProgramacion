namespace WebAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Entidadcreatetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaAdd = c.DateTime(nullable: false),
                        FechaUpdate = c.DateTime(nullable: false),
                        FechaDelete = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Entidades");
        }
    }
}
