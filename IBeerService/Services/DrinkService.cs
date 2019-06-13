using IBeerCore.Entities;
using IBeerData.Repository;
using IBeerService.POCO;
using System;
using System.Collections.Generic;

namespace IBeerService.Services
{
    public class DrinkService
    {
        public List<Drink> GetAll()
        {
            return new DrinkRepository().GetAll();
        }
        public Drink GetByBarCode(Int64 barCode)
        {
            return new DrinkRepository().GetByBarCode(barCode);
        }
    }
}
