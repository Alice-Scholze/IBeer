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
    }
}