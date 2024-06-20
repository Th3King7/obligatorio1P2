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
        //el usuario web inicia sesion en la pagina
        public IActionResult IniciarSesion(string email, string password)
        {
            try
            {
                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) && email.Length !=0 && password.Length != 0)
                {
                    object usuario = miSistema.IniciarSesion(email, password);
                    if (usuario != null)
                    {
                        if (usuario is Peon)
                        {
                            // Aquí redirige al usuario a la página correspondiente a su rol
                            HttpContext.Session.SetString("rol", "Peon");
                            HttpContext.Session.SetString("correo", email);
                            TempData["Mensaje"] = "Inicio de sesion correctamente";
                            return RedirectToAction("VacunarAnimal", "Peon");

                        }
                        else if (usuario is Capataz)
                        {
                            // Aquí redirige al usuario a la página correspondiente a su rol
                            HttpContext.Session.SetString("rol", "Capataz");
                            TempData["Mensaje"] = "Inicio de sesion correctamente";
                            return RedirectToAction("RegistrarBovino", "Capataz");

                        }
                        else
                        {
                            TempData["Mensaje"] = "usuario inválidas";
                        }
                    }
                }
                else
                {
                    TempData["Mensaje"] = "El email y la contraseña no pueden estar vacios";

                }
            }
            catch (Exception ex)
            {
                TempData["Mensaje"] = ex.Message;

            }

            return View("Login");
        }
        //Cerramos la sesion y limpiamos la variable de sesion
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            TempData["Mensaje"] = "Cierre de  sesion correctamente";
            // Redirigir a la página de inicio de sesión
            return RedirectToAction("Login", "Usuario");
        }
    }
}

