namespace IBeerData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drink", "LotID", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drink", "LotID");
        }
    }
}
