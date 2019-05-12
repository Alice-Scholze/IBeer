using System;
using System.Collections.Generic;

namespace CoreDistribuidor2.Entities
{
    public class Drink
    {
        public static List<Drink> drink = new List<Drink>()
        {
            new Drink{Id = 7894900019841, Name = "Coca-cola lata", Value = 3.00, Lot = "L00", ShelfLife = new DateTime(2019,10,30) },
            new Drink{Id = 7894900039849, Name = "Fanta Laranja lata", Value = 3.00, Lot = "L03", ShelfLife = new DateTime(2019,9,1) },
            new Drink{Id = 7894900919868, Name = "Kuat lata", Value = 3.00, Lot = "L07", ShelfLife = new DateTime(2019,10,10) },
            new Drink{Id = 7891991010481, Name = "Budweiser lata", Value = 3.00, Lot = "L99", ShelfLife = new DateTime(2019,12,24) },
            new Drink{Id = 7896045523412, Name = "Heineken lata", Value = 3.00, Lot = "L001", ShelfLife = new DateTime(2019,10,30) }
        };
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Lot { get; set; }
        public DateTime ShelfLife { get; set; }

        public Drink() { }

        public List<Drink> GetDrink()
        {
            return drink;
        }

        public Drink GetDrinkById(Int64 id)
        {
            return drink.Find(x => x.Id == id);
        }
    }
}
