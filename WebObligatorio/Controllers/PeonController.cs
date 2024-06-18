using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{
    public class PeonController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;


        public IActionResult MenuPeon()
        {

            return View();
        }
        public IActionResult TareasCompletadas()
        {
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
                    return RedirectToAction("IniciarSesion", "IniciarSesion");
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

        public IActionResult VacunarAnimal(DateTime fechaVacunacion, DateTime fechaVencimiento, string idAnimal, string nombreVacuna)
        {

            try
            {

                if (fechaVacunacion != null && fechaVencimiento != null && idAnimal != null && nombreVacuna != null)
                {
                    Vacuna vacunaBuscada = miSistema.BuscarVacuna(nombreVacuna);
                    Ganado animalBuscado = miSistema.BuscarAnimal(idAnimal);

                    if (vacunaBuscada != null && animalBuscado != null)
                    {

                        if (animalBuscado is Bovino bovino)
                        {
                            miSistema.AltaVacunacionAnimal(bovino, new Vacunado(vacunaBuscada, fechaVacunacion, fechaVencimiento));
                            TempData["Mensaje"] = "Alta vacunacion bovino exitosa";
                            return RedirectToAction("Peon", "VacunarAnimal");
                        }
                        else if (animalBuscado is Ovino ovino)

                        {
                            miSistema.AltaVacunacionAnimal(ovino, new Vacunado(vacunaBuscada, fechaVacunacion, fechaVencimiento));
                            TempData["Mensaje"] = "Alta vacunacion ovino exitosa";
                            return RedirectToAction("Peon", "VacunarAnimal");

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
            return View();
}

    }

}

