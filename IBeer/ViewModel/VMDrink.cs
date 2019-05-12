using IBeerCore.Entities;
using System;

namespace IBeer.ViewModel
{
    public class VMDrink
    {
        public Int64 BarCode { get; private set; }
        public Int64 LotID { get; private set; }
        public Int64 Amount { get; private set; }
        public Lot Lot { get; private set; }
        public Stock Stock { get; private set; }
        public String Name { get; private set; }

        public VMDrink SetName(string name)
        {
            Name = name;
            return this;
        }
        public VMDrink SetBarCode(Int64 barCode)
        {
            BarCode = barCode;
            return this;
        }
        public VMDrink SetLot(Lot lot)
        {
            this.Lot = lot;
            return this;
        }
        public VMDrink SetStock(Stock stock)
        {
            this.Stock = stock;
            return this;
        }
        public VMDrink SetLot(Int64 lot)
        {
            this.LotID = lot;
            return this;
        }
        public VMDrink SetAmount(Int64 amount)
        {
            Amount = amount;
            return this;
        }
    }
}