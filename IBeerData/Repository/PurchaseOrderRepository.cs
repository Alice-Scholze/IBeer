using IBeerCore.Entities;
using IBeerData.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace IBeerData.Repository
{
    public class PurchaseOrderRepository
    {
        private IBeerContext db = new IBeerContext();
        public List<PurchaseOrder> GetAll()
        {
            List<PurchaseOrder> purchases = db.PurchaseOrders.ToList();
            foreach(var purchase in purchases)
            {
                purchase.Itens = new PurchaseOrderItemRepository().GetByPurchase(purchase.Id);
            }

            return purchases;
        }
        public PurchaseOrder GetById(int id)
        {
            var purchase = db.PurchaseOrders.Where(p => p.Id == id).SingleOrDefault();
            purchase.Itens = new PurchaseOrderItemRepository().GetByPurchase(purchase.Id);
            return purchase;
        }

        public void Add(PurchaseOrder purchase)
        {
            db.PurchaseOrders.Add(purchase);
            db.SaveChanges();
            new PurchaseOrderItemRepository().Edit();
        }

        public void Update(PurchaseOrder purchase)
        {
            PurchaseOrder purchaseEntity = db.PurchaseOrders.Where(p => p.Id == purchase.Id).SingleOrDefault();
            purchaseEntity
                .SetProvider(purchase.Provider)
                .SetStatus(purchase.Status)
                .SetTotal();

            db.SaveChanges();
        }
    }
}
