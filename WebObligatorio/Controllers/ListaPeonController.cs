using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{
    public class ListaPeonController : Controller
    {
        private Sistema miSistema = new Sistema();
        public IActionResult Index()
        {
            ViewBag.Empleados = miSistema.Empleados;
            return View();
        }
    }
}
