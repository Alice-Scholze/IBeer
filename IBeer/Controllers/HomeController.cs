using IBeer.ViewModel;
using IBeerCore.Entities;
using IBeerService.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace IBeer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Drink> drinks = new DrinkService().GetAll();
            List<VMDrink> vms = new List<VMDrink>();
            foreach(var drink in drinks)
            {
                vms.Add(new VMDrink()
                            .SetName(drink.Name)
                            .SetBarCode(drink.BarCode)
                            .SetAmount(drink.Amount)
                            .SetLot(drink.LotID)
                            .SetLot(new LotService().GetByID(drink.LotID))
                            .SetStock(new StockService().GetByDrink(drink.BarCode))
                );
            }
            return View(vms);
        }
    }
}