namespace IBeerData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Provider",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cnpj = c.Long(nullable: false),
                        Api = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PurchaseOrderItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Purchase = c.Long(nullable: false),
                        BarCode = c.Long(nullable: false),
                        Amount = c.Long(nullable: false),
                        Value = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                        PurchaseOrder_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PurchaseOrder", t => t.PurchaseOrder_Id)
                .Index(t => t.PurchaseOrder_Id);
            
            CreateTable(
                "dbo.PurchaseOrder",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Provider = c.Long(nullable: false),
                        Total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseOrderItem", "PurchaseOrder_Id", "dbo.PurchaseOrder");
            DropIndex("dbo.PurchaseOrderItem", new[] { "PurchaseOrder_Id" });
            DropTable("dbo.PurchaseOrder");
            DropTable("dbo.PurchaseOrderItem");
            DropTable("dbo.Provider");
        }
    }
}
