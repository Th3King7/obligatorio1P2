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

        public IActionResult RegistrarPeon()
        {

            return View();
        }

        [HttpPost]
        public IActionResult RegistrarPeon(Peon peon)
        {
            peon.ValidarDatos();
            try
            {
                miSistema.AltaPeon(peon);
                return RedirectToAction("Index", "IniciarSesion");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"Error al registrar peón: {ex.Message}";
                return View(peon);
            }
        }
    }
}
