using IBeerCore.Entities;
using IBeerData.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IBeerData.Repository
{
    public class LotRepostiory
    {
        private IBeerContext db = new IBeerContext();
        public List<Lot> GetAll()
        {
            return db.Lots.ToList();
        }
        public Lot GetByID(Int64 id)
        {
            return db.Lots.Single(l => l.Id == id);
        }
    }
}
