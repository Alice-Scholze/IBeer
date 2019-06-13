using IBeerCore.Entities;
using IBeerData.Repository;
using System.Collections.Generic;

namespace IBeerService.Services
{
    public class ParameterService
    {
        public Parameter GetById(int id)
        {
            return new ParameterRepository().GetById(id);
        }
        public Parameter GetByDescription(string descrition)
        {
            return new ParameterRepository().GetByDescription(descrition);
        }
        
        public void Update(Parameter param)
        {
            new ParameterRepository().Update(param);
        }
        public List<Parameter> GetAll()
        {
            return new ParameterRepository().GetAll();
        }
    }
}
