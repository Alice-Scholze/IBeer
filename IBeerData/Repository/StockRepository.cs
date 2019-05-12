using IBeerCore.Entities;
using IBeerData.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace IBeerData.Repository
{
    public class StockRepository
    {
        private IBeerContext db;
        public List<Stock> GetAll()
        {
            return db.Stocks.ToList();
        }
        public Stock GetByDrink(int drink)
        {
            return db.Stocks.Single(s => s.Drink == drink);
        }
    }
}
