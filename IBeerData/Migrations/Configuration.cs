namespace IBeerData.Migrations
{
    using IBeerCore.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IBeerData.EntityFramework.IBeerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IBeerData.EntityFramework.IBeerContext context)
        {
            var lots = new List<Lot>
            {
                new Lot().SetDespription("LT01").SetShelfLife(new DateTime(2019,11,27)),
                new Lot().SetDespription("LT02").SetShelfLife(new DateTime(2019,11,27)),
                new Lot().SetDespription("LT03").SetShelfLife(new DateTime(2019,11,27)),
                new Lot().SetDespription("LT04").SetShelfLife(new DateTime(2019,11,27)),
                new Lot().SetDespription("LT05").SetShelfLife(new DateTime(2019,11,27))
            };
            lots.ForEach(s => context.Lots.AddOrUpdate(p => p.Despription, s));
            context.SaveChanges();

            var drinks = new List<Drink>
            {
            new Drink().SetBarCode(7894900019841).SetName("Coca-cola lata").SetAmount(12).SetLot(lots.Single(l => l.Despription == "LT01" && l.ShelfLife == new DateTime(2019,11,27)).Id),
            new Drink().SetBarCode(7894900039849).SetName("Fanta Laranja lata").SetAmount(12).SetLot(lots.Single(l => l.Despription == "LT02" && l.ShelfLife == new DateTime(2019,11,27)).Id),
            new Drink().SetBarCode(7894900919868).SetName("Kuat lata").SetAmount(12).SetLot(lots.Single(l => l.Despription == "LT03" && l.ShelfLife == new DateTime(2019,11,27)).Id),
            new Drink().SetBarCode(7891991010481).SetName("Budweiser lata").SetAmount(12).SetLot(lots.Single(l => l.Despription == "LT04" && l.ShelfLife == new DateTime(2019,11,27)).Id),
            new Drink().SetBarCode(7896045523412).SetName("Heineken lata").SetAmount(12).SetLot(lots.Single(l => l.Despription == "LT05" && l.ShelfLife == new DateTime(2019,11,27)).Id)
            };
            drinks.ForEach(s => context.Drinks.AddOrUpdate(p => p.BarCode, s));
            context.SaveChanges();

            var stocks = new List<Stock>
            {
                new Stock().SetDrink(drinks.Single(d => d.BarCode == 7894900019841).Id).SetCritical(3).SetMaximun(50).SetMinimun(7),
                new Stock().SetDrink(drinks.Single(d => d.BarCode == 7894900039849).Id).SetCritical(3).SetMaximun(50).SetMinimun(7),
                new Stock().SetDrink(drinks.Single(d => d.BarCode == 7894900919868).Id).SetCritical(3).SetMaximun(50).SetMinimun(7),
                new Stock().SetDrink(drinks.Single(d => d.BarCode == 7891991010481).Id).SetCritical(3).SetMaximun(50).SetMinimun(7),
                new Stock().SetDrink(drinks.Single(d => d.BarCode == 7896045523412).Id).SetCritical(3).SetMaximun(50).SetMinimun(7)
            };
            stocks.ForEach(s => context.Stocks.AddOrUpdate(p => p.Drink, s));
            context.SaveChanges();
        }
    }
}
