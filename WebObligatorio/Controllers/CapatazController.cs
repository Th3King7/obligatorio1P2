using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{
    public class CapatazController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;

        public IActionResult MenuCapataz()
        {
            ViewBag.Empleados = miSistema.EmpleadosPeones();
            return View();
        }
        public IActionResult ListaPeones()
        {
            ViewBag.Empleados = miSistema.EmpleadosPeones();
            return View();
        }
    }
}
