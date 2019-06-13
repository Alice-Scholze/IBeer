using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDistribuidor2.Entities
{
    public class PurchaseOrderItem
    {
        public Int64 Id { get; set; }
        public Int64 PurchaseOrder_Id { get; set; }
        public Int64 BarCode { get; set; }
        public Int64 Amount { get; set; }
        public Double Value { get; set; }
        public Double Total { get; set; }
    }
}
