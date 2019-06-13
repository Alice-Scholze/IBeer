using IBeerCore.Entities;
using IBeerData.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IBeerData.Repository
{
    public class DrinkRepository
    {
        private IBeerContext db = new IBeerContext();
        public List<Drink> GetAll()
        {
            return db.Drinks.ToList();
        }
        public Drink GetByBarCode(Int64 barCode)
        {
            return db.Drinks.Where(d => d.BarCode == barCode).FirstOrDefault();
        }
    }
}
