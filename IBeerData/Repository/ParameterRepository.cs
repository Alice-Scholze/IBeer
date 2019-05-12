using IBeerCore.Entities;
using IBeerData.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace IBeerData.Repository
{
    public class ParameterRepository
    {
        private IBeerContext db = new IBeerContext();
        public Parameter GetByDescription(string description)
        {
            return db.Parameters.Single(p => p.Description == description);
        }
        public List<Parameter> GetAll()
        {
            return db.Parameters.ToList();
        }
    }
}
