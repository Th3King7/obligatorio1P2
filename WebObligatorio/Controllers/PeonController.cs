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
            try
            {
                if (peon != null)
                {
                    peon.ValidarDatos();
                    miSistema.AltaPeon(peon);
                    TempData["Mensaje"] = "Alta peon exitosa";
                    return RedirectToAction("IniciarSesion","IniciarSesion");
                }
                else
                {
                    ViewBag.Mensaje = "Peon invalido";
                }

            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;

            }
            ViewBag.Mensaje = "Peon con datos nulos";
            return View();
        }
    }
 }

