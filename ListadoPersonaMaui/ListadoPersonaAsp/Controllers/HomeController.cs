using ListadoPersonaAsp.Models;
using ListadoPersonaBL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ListadoPersonaAsp.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View(ListadoBL.listadoPersonaBL());
        }

        
    }
}
