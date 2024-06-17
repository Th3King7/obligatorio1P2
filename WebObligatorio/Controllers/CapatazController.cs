using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{
    public class CapatazController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;

        public IActionResult RegistrarBovino()
        {

            return View();
        }

        [HttpPost]
        public IActionResult RegistrarBovino(Bovino bovino)
        {
            try
            {
                if (bovino != null)
                {
                    bovino.ValidarDatos();
                    miSistema.AltaBovino(bovino);
                    TempData["Mensaje"] = "Alta bovino exitosa";
                }
                else
                {
                    ViewBag.Mensaje = "bovino invalido";
                }

            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;

            }
            ViewBag.Mensaje = "bovino con datos nulos";
            return View();
        }
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
