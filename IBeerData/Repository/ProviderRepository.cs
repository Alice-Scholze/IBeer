using IBeerCore.Entities;
using IBeerData.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace IBeerData.Repository
{
    public class ProviderRepository
    {
        private IBeerContext db = new IBeerContext();
        public List<Provider> GetAll()
        {
            return db.Providers.ToList();
        }

        public Provider GetByCnpj(long cnpj)
        {
            return db.Providers.Where(p => p.Cnpj == cnpj).FirstOrDefault();
        }
    }
}
