﻿using IBeerCore.Entities;
using IBeerData.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace IBeerData.Repository
{
    public class DrinkRepository
    {
        private IBeerContext db;
        public List<Drink> GetAll()
        {
            return db.Drinks.ToList();
        }
    }
}
