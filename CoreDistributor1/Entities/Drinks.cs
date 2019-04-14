using System.Collections.Generic;

namespace CoreDistributor1.Entities
{
    public class Drinks : Base
    {
        public static List<Drinks> drinks = new List<Drinks>()
        {
            new Drinks{Id = 1, Name = "Coca Cola", Value = 2.00 },
            new Drinks{Id = 2, Name = "Coca Cola", Value = 2.00 },
            new Drinks{Id = 3, Name = "Coca Cola", Value = 2.00 },
            new Drinks{Id = 4, Name = "Coca Cola", Value = 2.00 },
            new Drinks{Id = 5, Name = "Coca Cola", Value = 2.00 },
            new Drinks{Id = 6, Name = "Coca Cola", Value = 2.00 },
            new Drinks{Id = 7, Name = "Coca Cola", Value = 2.00 },
            new Drinks{Id = 8, Name = "Fanta", Value = 2.00 }
        };
        public string Name { get; set; }
        public double Value { get; set; }

        public Drinks() { }

        public List<Drinks> GetDrinks()
        {
            return drinks;
        }

        public Drinks GetDrinksById(int id)
        {
            return drinks.Find(x => x.Id == id);
        }

        public Drinks GetDrinksByName(string name)
        {
            return drinks.Find(x => x.Name == name);
        }

    }
}
