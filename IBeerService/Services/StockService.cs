using IBeerCore.Entities;
using IBeerData.Repository;
using System;
using System.Collections.Generic;

namespace IBeerService.Services
{
    public class StockService
    {
        public List<Stock> GetExceededMinimum()
        {
            return new StockRepository().GetExceededMinimum();
        }
        public List<Stock> GetExceededMaximun()
        {
            return new StockRepository().GetExceededMaximun();
        }
        public List<Stock> GetExceededCritical()
        {
            return new StockRepository().GetExceededCritical();
        }
        public Stock GetByDrink(Int64 drink)
        {
            return new StockRepository().GetByDrink(drink);
        }
    }
}
