namespace Web.HealthFoot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablaDirectorioLA : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.AspNetDirectorio",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Titular = c.String(nullable: false, maxLength: 128),
                    Pais = c.String(nullable: false, maxLength: 128),
                    Estado = c.String(nullable: false, maxLength: 128),
                    Ciudad = c.String(nullable: false, maxLength: 128),
                    Calle = c.String(nullable: false, maxLength: 128),
                    CP = c.String(nullable: false, maxLength: 128),
                    Referencia = c.String(nullable: false, maxLength: 128),
                    Telefono = c.String(nullable: false, maxLength: 128),
                    Status = c.Int(defaultValue: 1),
                    IdUs = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => t.Id);

        }
        
        public override void Down()
        {

            DropTable("dbo.AspNetDirectorio");

        }
    }
}
