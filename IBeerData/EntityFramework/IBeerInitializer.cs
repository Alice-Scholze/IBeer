using IBeerCore.Entities;
using System;
using System.Collections.Generic;

namespace IBeerData.EntityFramework
{
    public class IBeerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<IBeerContext>
    {
        protected override void Seed(IBeerContext context)
        {
        }
    }
}