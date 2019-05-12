using IBeerCore.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace IBeerData.EntityFramework
{
    public class IBeerContext : DbContext
    {
        public IBeerContext() : base("IBeer")
        {

        }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public DbSet<Parameter> Parameters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
