using IBeerCore.Entities;
using IBeerCore.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IBeer.ViewModel
{
    public class VMPurchase
    {
        public int Id { get; set; }
        public Int64 Provider { get; set; }
        public List<VMPurchaseOrderItem> Itens { get; set; }
        public Double Total { get; set; }
        public int Status { get; set; }
        public PurchaseOrderStatus ListStatus { get; set; }
    }
}