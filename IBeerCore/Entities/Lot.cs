using System;
using System.Collections.Generic;

namespace IBeerCore.Entities
{
    public class Lot : Base
    {
        public String Despription { get; private set; }
        public DateTime ShelfLife { get; private set; }
        public List<Drink> Drinks { get; private set; }

        public Lot()
        {
            Drinks = new List<Drink>();
        }

        public Lot SetDespription(string despription)
        {
            Despription = despription;
            return this;
        }
        public Lot SetShelfLife(DateTime shelfLife)
        {
            ShelfLife = shelfLife;
            return this;
        }
        public Lot AddDrink(Drink drink)
        {
            Drinks.Add(drink);
            return this;
        }
    }
}
