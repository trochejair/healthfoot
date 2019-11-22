namespace Web.HealthFoot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablaPermisosLA : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.AspNetPermisos",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "PermisoNameIndex");

        }

        public override void Down()
        {

            DropIndex("dbo.AspNetPermisos", "PermisoNameIndex");
            DropTable("dbo.AspNetPermisos");

        }
    }
}
