using System.Collections.Generic;

namespace CoreDistributor1.Entities
{
    public class PurchaseOrder : Base
    {
        public static List<PurchaseOrder> purchaseOrders = new List<PurchaseOrder>();
        public List<Drinks> Drinks { get; set; }
        public double Amount { get; set; }

        public List<PurchaseOrder> GetPurchaseOrders()
        {
            return purchaseOrders;
        }

        public PurchaseOrder GetById(int id)
        {
            return purchaseOrders.Find(x => x.Id == id);
        }

        public void Insert(PurchaseOrder purchaseOrder)
        {
            purchaseOrders.Add(purchaseOrder);
        }
    }
}
