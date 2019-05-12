using IBeerCore.Entities;
using IBeerData.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace IBeerData.Repository
{
    public class PurchaseOrderRepository
    {
        private IBeerContext db;
        public List<PurchaseOrder> GetAll()
        {
            return db.PurchaseOrders.ToList();
        }
    }
}
