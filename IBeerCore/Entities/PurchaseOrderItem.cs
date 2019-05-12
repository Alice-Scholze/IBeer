using System;

namespace IBeerCore.Entities
{
    public class PurchaseOrderItem : Base
    {
        public Int64 Purchase { get; private set; }
        public Int64 BarCode { get; private set; }
        public Int64 Amount { get; private set; }
        public Double Value { get; private set; }
        public Double Total { get; private set; }
        public PurchaseOrderItem SetSequentialId(int id)
        {
            Id = id;
            return this;
        }
        public PurchaseOrderItem SetPurchase(int purchase)
        {
            Purchase = purchase;
            return this;
        }
        public PurchaseOrderItem SetBarCode(Int64 barCode)
        {
            BarCode = barCode;
            return this;
        }
        public PurchaseOrderItem SetAmount(Int64 amount)
        {
            Amount = amount;
            return SetTotal();
        }
        public PurchaseOrderItem SetValue(float value)
        {
            Value = value;
            return SetTotal();
        }
        public PurchaseOrderItem SetTotal()
        {
            Total = Amount * Value;
            return this;
        }
    }
}
