namespace IBeerData.Migrations
{
    using IBeerCore.Entities;
    using System;
    using System.Collections.Generic;
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
                new Lot().SetDespription("LT05").SetShelfLife(new DateTime(2019,11,27)),
                new Lot().SetDespription("LT06").SetShelfLife(new DateTime(2019,11,30))
            };
            lots.ForEach(s => context.Lots.AddOrUpdate(p => p.Despription, s));
            context.SaveChanges();

            var drinks = new List<Drink>
            {
            new Drink().SetBarCode(7894900019841).SetName("Coca-cola lata").SetAmount(2).SetLot(lots.Single(l => l.Despription == "LT01" && l.ShelfLife == new DateTime(2019,11,27)).Id),
            new Drink().SetBarCode(7894900019841).SetName("Coca-cola lata").SetAmount(1).SetLot(lots.Single(l => l.Despription == "LT06" && l.ShelfLife == new DateTime(2019,11,30)).Id),
            new Drink().SetBarCode(7894900039849).SetName("Fanta Laranja lata").SetAmount(2).SetLot(lots.Single(l => l.Despription == "LT02" && l.ShelfLife == new DateTime(2019,11,27)).Id),
            new Drink().SetBarCode(7894900919868).SetName("Kuat lata").SetAmount(50).SetLot(lots.Single(l => l.Despription == "LT03" && l.ShelfLife == new DateTime(2019,11,27)).Id),
            new Drink().SetBarCode(7891991010481).SetName("Budweiser lata").SetAmount(6).SetLot(lots.Single(l => l.Despription == "LT04" && l.ShelfLife == new DateTime(2019,11,27)).Id),
            new Drink().SetBarCode(7896045523412).SetName("Heineken lata").SetAmount(7).SetLot(lots.Single(l => l.Despription == "LT05" && l.ShelfLife == new DateTime(2019,11,27)).Id)
            };
            drinks.ForEach(s => context.Drinks.AddOrUpdate(p => p.BarCode, s));
            context.SaveChanges();

            var stocks = new List<Stock>
            {
                new Stock().SetDrink(7894900019841).SetAmount(drinks.Where(d => d.BarCode == 7894900019841).Sum(d => d.Amount)).SetCritical(3).SetMaximun(50).SetMinimun(7),
                new Stock().SetDrink(7894900039849).SetAmount(drinks.Where(d => d.BarCode == 7894900039849).Sum(d => d.Amount)).SetCritical(3).SetMaximun(50).SetMinimun(7),
                new Stock().SetDrink(7894900919868).SetAmount(drinks.Where(d => d.BarCode == 7894900919868).Sum(d => d.Amount)).SetCritical(3).SetMaximun(50).SetMinimun(7),
                new Stock().SetDrink(7891991010481).SetAmount(drinks.Where(d => d.BarCode == 7891991010481).Sum(d => d.Amount)).SetCritical(3).SetMaximun(50).SetMinimun(7),
                new Stock().SetDrink(7896045523412).SetAmount(drinks.Where(d => d.BarCode == 7896045523412).Sum(d => d.Amount)).SetCritical(3).SetMaximun(50).SetMinimun(7)
            };
            stocks.ForEach(s => context.Stocks.AddOrUpdate(p => p.Drink, s));
            context.SaveChanges();

            var provider = new List<Provider>
            {
                new Provider().SetName("Distribuidor 1").SetCnpj(00000000000).SetApi(""),
                new Provider().SetName("Distribuidor 2").SetCnpj(11111111111).SetApi("")
            };
            provider.ForEach(s => context.Providers.AddOrUpdate(p => p.Cnpj, s));
            context.SaveChanges();
        }
    }
}
