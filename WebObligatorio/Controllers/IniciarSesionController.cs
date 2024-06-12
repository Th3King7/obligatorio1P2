using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{

    public class IniciarSesionController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IniciarSesion(string email, string password)
        {

            // Aquí debes validar las credenciales
            // Por ejemplo, podrías buscar el peón en tu sistema con el email proporcionado
            // Si el peón existe y la contraseña coincide, puedes autenticar al usuario y redirigirlo
            Empleado empleado = miSistema.ObtenerUsuario(email, password);
            
            if (empleado != null && empleado.Password == password && )
            {
                // Autenticar al usuario (podrías usar ASP.NET Core Identity o implementar tu propio sistema)
                // Aquí redirigir al usuario a la página correspondiente a su rol
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Si las credenciales son inválidas, mostrar un mensaje de error
                ViewBag.ErrorMessage = "Credenciales inválidas";
                return View("Index");
            }
        }
    }
}
