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
        public PurchaseOrderItem SetBarCode(int barCode)
        {
            BarCode = barCode;
            return this;
        }
        public PurchaseOrderItem SetAmount(int amount)
        {
            Amount = amount;
            return SetTotal();
        }
        public PurchaseOrderItem SetValue(int value)
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
