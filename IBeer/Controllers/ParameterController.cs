using IBeerCore.Entities;
using IBeerService.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace IBeer.Controllers
{
    public class ParameterController : Controller
    {
        // GET: Parameter
        public ActionResult Parameters()
        {
            List<Parameter> parameters = new ParameterService().GetAll();
            return View(parameters);
        }
        
        public ActionResult Parameter(int id)
        {
            Parameter parameter = new ParameterService().GetById(id);
            return View(parameter);
        }

        [HttpPost]
        public ActionResult Edit(Parameter VMparameter)
        {
            ViewBag.Result = "Edição realizada com sucesso";
            if (ModelState.IsValid)
            {
                new ParameterService().Update(VMparameter);
                return View();
            }
            ViewBag.Result = "Erro ao editar parametro";
            return View();
        }
    }
}