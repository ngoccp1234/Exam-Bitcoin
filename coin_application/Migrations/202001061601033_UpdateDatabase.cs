namespace coin_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coins", "Volume24h", c => c.Double(nullable: false));
            DropColumn("dbo.Coins", "Volumn24h");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coins", "Volumn24h", c => c.Double(nullable: false));
            DropColumn("dbo.Coins", "Volume24h");
        }
    }
}
