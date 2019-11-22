namespace Web.HealthFoot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnasUsersLeonardo : DbMigration
    {
        public override void Up()
        {

            AddColumn("dbo.AspNetUsers", "ApePat", c => c.String(maxLength: 50));
            AddColumn("dbo.AspNetUsers", "ApeMat", c => c.String(maxLength: 50));
            AddColumn("dbo.AspNetUsers", "IdRol", c => c.Int(nullable: true));
            AddColumn("dbo.AspNetUsers", "Status", c => c.Int(defaultValue: 1));
        }

        public override void Down()
        {

            DropColumn("dbo.AspNetUsers", "ApePat");
            DropColumn("dbo.AspNetUsers", "ApeMat");
            DropColumn("dbo.AspNetUsers", "IdRol");
            DropColumn("dbo.AspNetUsers", "Status");

        }

    }
}
