namespace IBeerData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PurchaseOrderItem", "PurchaseOrder_Id", "dbo.PurchaseOrder");
            DropIndex("dbo.PurchaseOrderItem", new[] { "PurchaseOrder_Id" });
            AddColumn("dbo.PurchaseOrderItem", "PurchaseOrder_Id1", c => c.Int());
            AlterColumn("dbo.PurchaseOrderItem", "PurchaseOrder_Id", c => c.Long(nullable: false));
            CreateIndex("dbo.PurchaseOrderItem", "PurchaseOrder_Id1");
            AddForeignKey("dbo.PurchaseOrderItem", "PurchaseOrder_Id", "dbo.PurchaseOrder", "Id");
            DropColumn("dbo.PurchaseOrderItem", "Purchase");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PurchaseOrderItem", "Purchase", c => c.Long(nullable: false));
            DropForeignKey("dbo.PurchaseOrderItem", "PurchaseOrder_Id1", "dbo.PurchaseOrder");
            DropIndex("dbo.PurchaseOrderItem", new[] { "PurchaseOrder_Id1" });
            AlterColumn("dbo.PurchaseOrderItem", "PurchaseOrder_Id", c => c.Int());
            DropColumn("dbo.PurchaseOrderItem", "PurchaseOrder_Id1");
            CreateIndex("dbo.PurchaseOrderItem", "PurchaseOrder_Id");
            AddForeignKey("dbo.PurchaseOrderItem", "PurchaseOrder_Id", "dbo.PurchaseOrder", "Id");
        }
    }
}
