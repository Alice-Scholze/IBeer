using System;

namespace IBeerCore.Entities
{
    public class Provider : Base
    {
        public String Name { get; private set; }
        public Int64 Cnpj { get; private set; }
        public string ApiDrink { get; private set; }
        public string ApiPurchaseOrder { get; private set; }

        public Provider SetSquentialId(int id)
        {
            Id = id;
            return this;
        }
        public Provider SetName(string name)
        {
            Name = name;
            return this;
        }
        public Provider SetCnpj(Int64 cnpj)
        {
            Cnpj = cnpj;
            return this;
        }
        public Provider SetApiDrink(string api)
        {
            ApiDrink = api;
            return this;
        }
        public Provider SetApiPurchaseOrder(string api)
        {
            ApiPurchaseOrder = api;
            return this;
        }
    }
}
