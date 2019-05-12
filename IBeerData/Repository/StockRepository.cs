using IBeerCore.Entities;
using IBeerData.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IBeerData.Repository
{
    public class StockRepository
    {
        private IBeerContext db = new IBeerContext();
        public List<Stock> GetAll()
        {
            return db.Stocks.ToList();
        }
        public Stock GetByDrink(Int64 drink)
        {
            return db.Stocks.Single(s => s.Drink == drink);
        }
        public List<Stock> GetExceededMinimum()
        {
            return db.Stocks.Where(s => s.Amount < s.Minimun).ToList();
        }
        public List<Stock> GetExceededCritical()
        {
            return db.Stocks.Where(s => s.Amount < s.Critical).ToList();
        }
        public List<Stock> GetExceededMaximun()
        {
            return db.Stocks.Where(s => s.Amount < s.Maximun).ToList();
        }
    }
}
