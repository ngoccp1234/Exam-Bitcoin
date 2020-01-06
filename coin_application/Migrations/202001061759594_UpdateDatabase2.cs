namespace coin_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "FullName", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.AspNetRoles", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetRoles", "Description", c => c.String());
            AlterColumn("dbo.AspNetUsers", "FullName", c => c.String());
        }
    }
}
