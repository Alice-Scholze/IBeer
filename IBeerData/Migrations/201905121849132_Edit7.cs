namespace IBeerData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parameter",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Provider", "ApiDrink", c => c.String());
            AddColumn("dbo.Provider", "ApiPurchaseOrder", c => c.String());
            DropColumn("dbo.Provider", "Api");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Provider", "Api", c => c.String());
            DropColumn("dbo.Provider", "ApiPurchaseOrder");
            DropColumn("dbo.Provider", "ApiDrink");
            DropTable("dbo.Parameter");
        }
    }
}
