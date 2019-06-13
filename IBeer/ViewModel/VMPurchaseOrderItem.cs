using System;

namespace IBeer.ViewModel
{
    public class VMPurchaseOrderItem
    {
        public String Description { get; set; }
        public Int64 BarCode { get; set; }
        public Int64 Amount { get; set; }
        public Double Value { get; set; }
        public Double Total { get; set; }
    }
}