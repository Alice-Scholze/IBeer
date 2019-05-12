using IBeerCore.Entities;
using IBeerData.Repository;
using System;

namespace IBeerService.Services
{
    public class LotService
    {
        public Lot GetByID(Int64 id)
        {
            return new LotRepostiory().GetByID(id);
        }
    }
}
