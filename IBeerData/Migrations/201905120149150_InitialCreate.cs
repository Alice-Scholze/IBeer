namespace IBeerData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drink",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BarCode = c.Long(nullable: false),
                        Amount = c.Long(nullable: false),
                        Lot_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lot", t => t.Lot_Id)
                .Index(t => t.Lot_Id);
            
            CreateTable(
                "dbo.Lot",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Despription = c.String(),
                        ShelfLife = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Drink", "Lot_Id", "dbo.Lot");
            DropIndex("dbo.Drink", new[] { "Lot_Id" });
            DropTable("dbo.Lot");
            DropTable("dbo.Drink");
        }
    }
}
