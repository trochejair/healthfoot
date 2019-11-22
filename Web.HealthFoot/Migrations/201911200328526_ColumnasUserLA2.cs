namespace Web.HealthFoot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnasUserLA2 : DbMigration
    {
        public override void Up()
        {

            AddColumn("dbo.AspNetUsers", "Registro", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "UltimaVisita", c => c.DateTime());

        }
        
        public override void Down()
        {

            DropColumn("dbo.AspNetUsers", "Registro");
            DropColumn("dbo.AspNetUsers", "UltimaVisita");

        }
    }
}
