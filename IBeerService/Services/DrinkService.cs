﻿using IBeerCore.Entities;
using IBeerData.Repository;
using System.Collections.Generic;

namespace IBeerService.Services
{
    public class DrinkService
    {
        public List<Drink> GetAll()
        {
            return new DrinkRepository().GetAll();
        }
    }
}