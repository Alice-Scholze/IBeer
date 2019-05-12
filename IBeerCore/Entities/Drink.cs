using System;

namespace IBeerCore.Entities
{
    public class Drink : Base
    {
        public String Name { get; private set; }
        public Int64 BarCode { get; private set; }
        public Int64 LotId { get; private set; }
        public Int64 Amount { get; private set; }

        public Drink SetSequentialId(int id)
        {
            Id = id;
            return this;
        }
        public Drink SetName(string name)
        {
            Name = name;
            return this;
        }
        public Drink SetBarCode(Int64 barCode)
        {
            BarCode = barCode;
            return this;
        }
        public Drink SetLot(Int64 lotId)
        {
            this.LotId = lotId;
            return this;
        }
        public Drink SetAmount(Int64 amount)
        {
            Amount = amount;
            return this;
        }
    }
}
