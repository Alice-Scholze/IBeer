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
        public Parameter GetById(int id)
        {
            return db.Parameters.Single(p => p.Id == id);
        }
        public void Update(Parameter parameter)
        {
            Parameter param =  db.Parameters.Single(p => p.Id == parameter.Id);
            param.SetParameter(parameter.Description, parameter.Value);
            db.SaveChanges();
        }
        public List<Parameter> GetAll()
        {
            return db.Parameters.ToList();
        }
    }
}
