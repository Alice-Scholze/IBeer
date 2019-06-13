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
            string api = "";

            foreach(var drink in stock)
            {
                barCode = drink.Drink;
                value = 0;
                cnpj = 0;
                foreach (var provider in providers)
                {
                    var drinkProvider = new ProviderService().GetProviderDrinkAsync(provider.ApiDrink, drink.Drink);
                    if (drinkProvider != null)
                    {
                        if(value == 0 || drinkProvider.Value < value)
                        {
                            cnpj = provider.Cnpj;
                            value = drinkProvider.Value;
                            api = provider.ApiPurchaseOrder;
                        }
                    }
                }
                if(cnpj != 0)
                {
                    Int64 quantity = 0;
                    if (Convert.ToInt16(stockIdeal.Value) == StockIdeal.MaximunValue.GetHashCode())
                        quantity = drink.Maximun - drink.Amount;
                    else if (Convert.ToInt16(stockIdeal.Value) == StockIdeal.MediumValue.GetHashCode())
                        quantity = (drink.Minimun + drink.Maximun) / 2;
                    else if (Convert.ToInt16(stockIdeal.Value) == StockIdeal.MinimunValue.GetHashCode())
                        quantity = drink.Minimun;

                    purchases.Add(
                        new PurchaseOrder()
                            .SetProvider(cnpj)
                            .SetStatus(automatic.Value == "True" ? PurchaseOrderStatus.AutomaticallyApproved.GetHashCode() : PurchaseOrderStatus.Waiting.GetHashCode())
                            .AddItens(new PurchaseOrderItem()
                                .SetBarCode(barCode)
                                .SetValue(value)
                                .SetAmount(quantity))
                            .SetTotal()
                    );
                }
            }
            foreach(var purchase in purchases){
                new PurchaseOrderRepository().Add(purchase);
                PurchaseOrderProvider(api, purchase);
            }
        }

        public List<PurchaseOrder> GetAll()
        {
            return new PurchaseOrderRepository().GetAll();
        }

        public PurchaseOrder GetById(int id)
        {
            return new PurchaseOrderRepository().GetById(id);
        }

        public void Update(PurchaseOrder purchase)
        {
            new PurchaseOrderRepository().Update(purchase);
            if(purchase.Status == PurchaseOrderStatus.Approved.GetHashCode())
            {
                var provider = new ProviderService().GetByCnpj(purchase.Provider);
                PurchaseOrderProvider(provider.ApiPurchaseOrder, purchase);
            }
        }
        public void PurchaseOrderProvider(string api, PurchaseOrder purchase)
        {
            new ProviderService().GeneratePurchaseOrder(api, purchase);
        }
    }
}
