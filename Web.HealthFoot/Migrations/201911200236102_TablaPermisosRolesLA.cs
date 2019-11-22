namespace Web.HealthFoot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablaPermisosRolesLA : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.AspNetPermisosRoles",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(nullable: false, maxLength: 256),
                    IdRol = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "PermisosRolNameIndex");

        }

        public override void Down()
        {

            DropIndex("dbo.AspNetPermisosRoles", "PermisoNameIndex");
            DropTable("dbo.AspNetPermisosRoles");

        }

    }
}
