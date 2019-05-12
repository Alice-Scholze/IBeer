namespace IBeerData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stock", "Amount", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stock", "Amount");
        }
    }
}
