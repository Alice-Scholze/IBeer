using IBeer.ViewModel;
using IBeerCore.Entities;
using IBeerService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBeer.Controllers
{
    public class PurchaseOrderController : Controller
    {
        // GET: PurchaseOrder
        public ActionResult Verify()
        {
            new PurchaseOrderService().GeneratePurcheseOrder();
            return View();
        }

        public ActionResult Purchases()
        {
            List<PurchaseOrder> purcharse = new PurchaseOrderService().GetAll();
            List<VMPurchase> vmPurchase = new List<VMPurchase>();
            foreach (var p in purcharse)
            {
                VMPurchase vm = new VMPurchase()
                {
                    Id = p.Id,
                    Total = p.Total,
                    Status = p.Status,
                    Provider = p.Provider
                };
                foreach(var item in p.Itens)
                {
                    var product = new DrinkService().GetByBarCode(item.BarCode);
                    vm.Itens = new List<VMPurchaseOrderItem>()
                    { new VMPurchaseOrderItem
                        {
                            Amount = item.Amount,
                            BarCode = item.BarCode,
                            Total = item.Total,
                            Value = item.Value,
                            Description = product.Name
                        }
                    };
                }
                vmPurchase.Add(vm);
            }
            return View(vmPurchase);
        }

        
        public ActionResult Update(int id, int status)
        {
            PurchaseOrder purchase = new PurchaseOrderService().GetById(id);
            purchase.SetStatus(status);
            new PurchaseOrderService().Update(purchase);
            return View();
        }
    }
}