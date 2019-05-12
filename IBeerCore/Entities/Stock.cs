using System;

namespace IBeerCore.Entities
{
    public class Stock : Base
    {
        public Int64 Drink { get; private set; }
        public Int64 Minimun { get; private set; }
        public Int64 Maximun { get; private set; }
        public Int64 Critical { get; private set; }

        public Stock SetSequentiaId(int id)
        {
            Id = id;
            return this;
        }
        public Stock SetDrink(int drink)
        {
            Drink = drink;
            return this;
        }
        public Stock SetMinimun(int minimun)
        {
            Minimun = minimun;
            return this;
        }
        public Stock SetMaximun(int maximun)
        {
            Maximun = maximun;
            return this;
        }
        public Stock SetCritical(int critical)
        {
            Critical = critical;
            return this;
        }
    }
}
