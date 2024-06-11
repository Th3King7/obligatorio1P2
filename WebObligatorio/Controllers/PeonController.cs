using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{
    public class PeonController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;

        public IActionResult ListaPeones()
        {
            ViewBag.Empleados = miSistema.EmpleadosPeones();
            return View();
        }
        public IActionResult TareasCompletadas() {
            ViewBag.Tareas = miSistema.ListadoTareasPeones();
            return View();
        }

        //[HttpPost]
        public IActionResult RegistrarPeon(Peon peon)
        {

            peon.ValidarDatos();
            miSistema.AltaPeon(peon);
            return View();
        }

        public IActionResult RegistroPeon()
        {
            return View();
        }
    }
}
