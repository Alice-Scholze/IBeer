using System;
using System.Collections.Generic;

namespace CoreDistributor1.Entities
{
    public class Drinks : Base
    {
        public static List<Drinks> drinks = new List<Drinks>()
        {
            new Drinks{Id = 7894900019841, Name = "Coca-cola lata", Value = 2.00, Lot = "L30", ShelfLife = new DateTime(2019,10,29) },
            new Drinks{Id = 7894900039849, Name = "Fanta Laranja lata", Value = 2.00, Lot = "L34", ShelfLife = new DateTime(2019,10,28) },
            new Drinks{Id = 7894900919868, Name = "Kuat lata", Value = 2.00, Lot = "L34", ShelfLife = new DateTime(2019,10,27) },
            new Drinks{Id = 7891991010481, Name = "Budweiser lata", Value = 2.00, Lot = "L01", ShelfLife = new DateTime(2019,10,26) },
            new Drinks{Id = 7896045523412, Name = "Heineken lata", Value = 2.00, Lot = "L02", ShelfLife = new DateTime(2019,10,25)}
        };
        public string Name { get; set; }
        public double Value { get; set; }
        public string Lot { get; set; }
        public DateTime ShelfLife { get; set; }

        public Drinks() { }

        public List<Drinks> GetDrinks()
        {
            return drinks;
        }

        public Drinks GetDrinksById(Int64 id)
        {
            return drinks.Find(x => x.Id == id);
        }

    }
}
