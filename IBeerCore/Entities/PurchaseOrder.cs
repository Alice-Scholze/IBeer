using IBeerCore.Enum;
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
        public int Status { get; private set; }
        public PurchaseOrder()
        {
            Itens = new List<PurchaseOrderItem>();
        }
        public PurchaseOrder SetSequentialId(int id)
        {
            Id = id;
            return this;
        }
        public PurchaseOrder SetProvider(Int64 provider)
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
        public PurchaseOrder SetStatus(PurchaseOrderStatus status)
        {
            Status = status.GetHashCode();
            return this;
        }
    }
}
