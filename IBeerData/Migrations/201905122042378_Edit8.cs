namespace IBeerData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseOrder", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PurchaseOrder", "Status");
        }
    }
}
