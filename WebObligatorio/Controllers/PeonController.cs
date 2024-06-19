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

            ViewBag.Tareas = miSistema.ListadoTareasPeones(email);

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
            ViewBag.Mensaje = "Peon con datos nulos";
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

                if (fechaDeVacunacion != null && fechaDeVencimiento != null && idAnimal != null && nombreVacuna != null)
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
                        ViewBag.Mensaje = "Peon invalido";
                    }

                }

            }

            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;

            }
            ViewBag.Mensaje = "Peon con datos nulos";
            return View("VacunarAnimal");
        }

    }

}

