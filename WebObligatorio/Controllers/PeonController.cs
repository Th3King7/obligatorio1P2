using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{
    public class PeonController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;
        public IActionResult DatosPersonales()
        {

            ViewBag.Empleados = miSistema.Empleados;
            string usuarioLogueado = HttpContext.Session.GetString("correo");
            ViewBag.Peon = miSistema.ObtenerPeon(usuarioLogueado);

            return View();
        }

        public IActionResult TareasIncompletas()
        {
            string usuarioLogueado = HttpContext.Session.GetString("correo");
            ViewBag.Tareas = miSistema.ListadoTareasIncompletasPeon(usuarioLogueado);
            return View();
        }
        public IActionResult Tareas(string email)
        {
            try
            {
                if (!string.IsNullOrEmpty(email))
                {
                    ViewBag.Tareas = miSistema.ListadoTareasPeones(email);
                }
                else
                {
                    TempData["Mensaje"] = "Email nulo";

                }

            }
            catch (Exception ex)
            {
                TempData["Mensaje"] = ex.Message;

            }

            return View();
        }

        public IActionResult CompletarTarea(int idTarea)
        {
            try
            {
                if (idTarea != null && idTarea != 0)
                {
                    string usuarioLogueado = HttpContext.Session.GetString("correo");
                    ViewBag.TareaBuscada = miSistema.BuscarTarea(usuarioLogueado, idTarea);
                }
            }
            catch (Exception ex)
            {
                TempData["Mensaje"] = ex.Message;

            }
            return View();


        }
        [HttpPost]
        public IActionResult CompletarTarea(int idTarea, string TareaCompletada, string Comentario)
        {
            try
            {
                if (idTarea != 0 && idTarea != null && !string.IsNullOrEmpty(TareaCompletada) && !string.IsNullOrEmpty(Comentario))
                {
                    string usuarioLogueado = HttpContext.Session.GetString("correo");
                    Tarea tareaBuscada = miSistema.BuscarTarea(usuarioLogueado, idTarea);
                    bool verdadero = false;

                    if (usuarioLogueado != null && tareaBuscada != null)
                    {
                        if (TareaCompletada == "true")
                        {
                            verdadero = true;
                            miSistema.ModificarTarea(usuarioLogueado, tareaBuscada, verdadero, Comentario);
                            TempData["Mensaje"] = "La tarea se completo correctamente";
                            return RedirectToAction("TareasIncompletas", "Peon");
                        }
                        else
                        {
                            TempData["Mensaje"] = "Tarea completada tiene que estar marcada.";
                        }
                    }
                    else
                    {
                        TempData["Mensaje"] = "Datos nulos.";
                    }
                }
                else
                {
                    TempData["Mensaje"] = "No se encontro unUsuario  y una tarea. ";
                }
            }
            catch (Exception ex)
            {
                TempData["Mensaje"] = ex.Message;

            }
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
                    TempData["Mensaje"] = "Peon registrado exitosamente";
                    return RedirectToAction("Login", "Usuario");
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
            return View();
        }

        public IActionResult VacunarAnimal()
        {
            ViewBag.Animales = miSistema.Animales;
            ViewBag.Vacunas = miSistema.Vacunas;
            return View();
        }
        [HttpPost]

        public IActionResult VacunarAnimal(DateTime fechaDeVacunacion, DateTime fechaDeVencimiento, string idAnimal, string nombreVacuna)
        {
            try
            {
                if (fechaDeVacunacion != null && fechaDeVencimiento != null && !string.IsNullOrEmpty(idAnimal) && !string.IsNullOrEmpty(nombreVacuna))
                {
                    Vacuna vacunaBuscada = miSistema.BuscarVacuna(nombreVacuna);
                    Ganado animalBuscado = miSistema.BuscarAnimal(idAnimal);

                    if (vacunaBuscada != null && animalBuscado != null)
                    {

                        if (animalBuscado is Bovino bovino)
                        {
                            miSistema.AltaVacunacionAnimal(bovino, new Vacunado(vacunaBuscada, fechaDeVacunacion, fechaDeVencimiento));
                            TempData["Mensaje"] = "Alta vacunacion bovino exitosa";
                        }
                        else if (animalBuscado is Ovino ovino)

                        {
                            miSistema.AltaVacunacionAnimal(ovino, new Vacunado(vacunaBuscada, fechaDeVacunacion, fechaDeVencimiento));
                            TempData["Mensaje"] = "Alta vacunacion ovino exitosa";

                        }
                    }
                    else
                    {
                        TempData["Mensaje"] = "No se encontro Vacuna ni un Animal";

                    }

                }
                else
                {
                    TempData["Mensaje"] = "Datos nulos";

                }

            }

            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;

            }
            ViewBag.Animales = miSistema.Animales;
            ViewBag.Vacunas = miSistema.Vacunas;
            return View();
        }

    }

}

