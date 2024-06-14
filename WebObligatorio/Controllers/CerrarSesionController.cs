using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{
    public class CerrarSesionController : Controller
    {
        /*/ Mostrar la vista de inicio de sesión
        public IActionResult IniciarSesion()
        {
            return View();
        }*/
        
        //[HttpPost]
        public IActionResult Logout()
        {
            // Limpiar la sesión del usuario
            HttpContext.Session.Clear();

            // Redirigir a la página de inicio de sesión
            return RedirectToAction("IniciarSesion", "IniciarSesion");
        }
    }
}
