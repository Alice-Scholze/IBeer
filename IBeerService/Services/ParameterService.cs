using IBeerCore.Entities;
using IBeerData.Repository;
using System.Collections.Generic;

namespace IBeerService.Services
{
    public class ParameterService
    {
        public Parameter GetByDescription(string descrition)
        {
            return new ParameterRepository().GetByDescription(descrition);
        }
        public List<Parameter> GetAll()
        {
            return new ParameterRepository().GetAll();
        }
    }
}
