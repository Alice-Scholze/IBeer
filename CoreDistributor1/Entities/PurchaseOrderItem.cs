using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDistributor1.Entities
{
    public class PurchaseOrderItem : Base
    {
        public Int64 PurchaseOrder_Id { get; set; }
        public Int64 BarCode { get; set; }
        public Int64 Amount { get; set; }
        public Double Value { get; set; }
        public Double Total { get; set; }
    }
}
