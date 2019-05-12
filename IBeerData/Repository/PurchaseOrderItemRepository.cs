using IBeerCore.Entities;
using IBeerData.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace IBeerData.Repository
{
    public class PurchaseOrderItemRepository
    {
        private IBeerContext db;
        public List<PurchaseOrderItem> GetAll()
        {
            return db.PurchaseOrderItems.ToList();
        }
    }
}
