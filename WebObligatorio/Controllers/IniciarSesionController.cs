using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{

    public class IniciarSesionController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;
        public IActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IniciarSesion(string email, string password)
        {

            // Aquí debes validar las credenciales
            // Por ejemplo, podrías buscar el peón en tu sistema con el email proporcionado
            // Si el peón existe y la contraseña coincide, puedes autenticar al usuario y redirigirlo
            //Empleado empleado = miSistema.ObtenerUsuario(email, password);
         object usuario = miSistema.IniciarSesion(email, password);

        if (usuario is Peon)
            {
                // Autenticar al usuario (podrías usar ASP.NET Core Identity o implementar tu propio sistema)
                // Aquí redirigir al usuario a la página correspondiente a su rol
               
                return RedirectToAction("ListarPeon", "Peon");
            }
            else if (usuario is Capataz) 
            {
                //return RedirectToAction("Index", "Home");
                return RedirectToAction("RegistrarPeon", "Peon");
            }
            else 
            {
                // Si las credenciales son inválidas, mostrar un mensaje de error
                ViewBag.ErrorMessage = "Credenciales inválidas";                
            }
            return View();
        }
    }
}
