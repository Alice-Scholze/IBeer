namespace IBeerData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drink", "LotId", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drink", "LotId");
        }
    }
}
