using IBeerCore.Entities;
using IBeerService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        
        public ActionResult Parameter(string description)
        {
            return View();
        }
    }
}