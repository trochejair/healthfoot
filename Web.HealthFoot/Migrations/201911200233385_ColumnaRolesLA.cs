namespace Web.HealthFoot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnaRolesLA : DbMigration
    {
        public override void Up()
        {

            AddColumn("dbo.AspNetRoles", "Status", c => c.Int(defaultValue: 1));

        }

        public override void Down()
        {

            DropColumn("dbo.AspNetRoles", "Status");

        }

    }
}
