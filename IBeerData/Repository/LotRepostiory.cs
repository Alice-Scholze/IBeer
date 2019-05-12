using IBeerCore.Entities;
using IBeerData.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace IBeerData.Repository
{
    public class LotRepostiory
    {
        private IBeerContext db;
        public List<Lot> GetAll()
        {
            return db.Lots.ToList();
        }
        public Lot GetByID(int id)
        {
            return db.Lots.Single(l => l.Id == id);
        }
    }
}
