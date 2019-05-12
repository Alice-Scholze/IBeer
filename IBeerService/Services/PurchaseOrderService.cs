using IBeerCore.Entities;
using IBeerCore.Enum;
using IBeerData.Repository;
using System;
using System.Collections.Generic;

namespace IBeerService.Services
{
    public class PurchaseOrderService
    {
        public void GeneratePurcheseOrder()
        {
            List<Stock> stock = new StockService().GetExceededMinimum();
            List<Provider> providers = new ProviderService().GetAll();
            Parameter stockIdeal = new ParameterService().GetByDescription(Parameters.StockIdeal.ToString());
            Parameter automatic = new ParameterService().GetByDescription(Parameters.AutomaticPurchaseOrder.ToString());
            List<PurchaseOrder> purchases = new List<PurchaseOrder>();
            long cnpj, barCode;
            float value;

            foreach(var drink in stock)
            {
                barCode = drink.Drink;
                value = 0;
                cnpj = 0;
                foreach (var provider in providers)
                {
                    var drinkProvider = new ProviderService().GetProviderDrinkAsync(provider.ApiDrink, drink.Drink).Result;
                    if (drinkProvider != null)
                    {
                        if(value == 0 || drinkProvider.Value < value)
                        {
                            cnpj = provider.Cnpj;
                            value = drinkProvider.Value;
                        }
                    }
                }
                if(cnpj != 0)
                {
                    Int64 quantity = 0;
                    if (stockIdeal.ToString() == StockIdeal.MaximunValue.ToString())
                        quantity = drink.Maximun - drink.Amount;
                    else if (stockIdeal.ToString() == StockIdeal.MediumValue.ToString())
                        quantity = (drink.Minimun + drink.Maximun) / 2;
                    else if (stockIdeal.ToString() == StockIdeal.MinimunValue.ToString())
                        quantity = drink.Minimun;

                    purchases.Add(
                        new PurchaseOrder()
                            .SetProvider(cnpj)
                            .SetStatus(automatic.Value == "true" ? PurchaseOrderStatus.AutomaticallyApproved : PurchaseOrderStatus.Waiting)
                            .AddItens(new PurchaseOrderItem()
                                .SetBarCode(barCode)
                                .SetValue(value)
                                .SetAmount(quantity))
                    );
                }
            }
            foreach(var purchase in purchases){
                new PurchaseOrderRepository().Add(purchase);
            }
        }
    }
}
