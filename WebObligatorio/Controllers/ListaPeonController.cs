using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{
    public class ListaPeonController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;
        public IActionResult Index()
        {
            ViewBag.Empleados = miSistema.EmpleadosPeones();
            return View();
        }
    }
}
