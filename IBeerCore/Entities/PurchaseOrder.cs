using System;
using System.Collections.Generic;
using System.Linq;

namespace IBeerCore.Entities
{
    public class PurchaseOrder : Base
    {
        public Int64 Provider { get; set; }
        public List<PurchaseOrderItem> Itens { get; set; }
        public Double Total { get; set; }
        public PurchaseOrder()
        {
            Itens = new List<PurchaseOrderItem>();
        }
        public PurchaseOrder SetSequentialId(int id)
        {
            Id = id;
            return this;
        }
        public PurchaseOrder SetProvider(int provider)
        {
            Provider = provider;
            return this;
        }
        public PurchaseOrder AddItens(PurchaseOrderItem item)
        {
            Itens.Add(item);
            return SetTotal();
        }
        public PurchaseOrder RemoveItens(PurchaseOrderItem item)
        {
            Itens.Remove(item);
            return SetTotal();
        }
        public PurchaseOrder SetTotal()
        {
            Total = Itens.Sum(i => i.Total);
            return this;
        }
    }
}
