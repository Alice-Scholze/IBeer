using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDistribuidor2.Entities
{
    public class PurchaseOrder
    {
        public static List<PurchaseOrder> purchaseOrders = new List<PurchaseOrder>();
        public Int64 Id { get; set; }
        public Int64 Provider { get; set; }
        public List<PurchaseOrderItem> Itens { get; set; }
        public Double Total { get; set; }
        public int Status { get; private set; }

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
