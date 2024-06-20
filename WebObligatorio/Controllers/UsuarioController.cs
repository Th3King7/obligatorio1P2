using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{

    public class UsuarioController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IniciarSesion(string email, string password)
        {
            try
            {
                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    object usuario = miSistema.IniciarSesion(email, password);
                    if (usuario != null)
                    {
                        if (usuario is Peon)
                        {
                            // Autenticar al usuario (podrías usar ASP.NET Core Identity o implementar tu propio sistema)
                            // Aquí redirigir al usuario a la página correspondiente a su rol
                            HttpContext.Session.SetString("rol", "Peon");
                            HttpContext.Session.SetString("correo", email);
                            TempData["Mensaje"] = "Inicio de sesion correctamente";
                            return RedirectToAction("DatosPersonales", "Peon");

                        }
                        else if (usuario is Capataz)
                        {
                            //return RedirectToAction("Index", "Home");
                            HttpContext.Session.SetString("rol", "Capataz");
                            TempData["Mensaje"] = "Inicio de sesion correctamente";
                            return RedirectToAction("RegistrarBovino", "Capataz");

                        }
                        else
                        {
                            TempData["Mensaje"] = "Credenciales inválidas";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["Mensaje"] = ex.Message;

            }
            return View("Login");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            TempData["Mensaje"] = "Cierre de  sesion correctamente";
            // Redirigir a la página de inicio de sesión
            return RedirectToAction("Login", "Usuario");
        }
    }
}

