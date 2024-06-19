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


        public IActionResult AsignarAnimalAPotrero()
        {

            ViewBag.Potreros = miSistema.Potreros;
            ViewBag.Animales = miSistema.Animales;
            return View();
        }

        [HttpPost]
        public IActionResult AsignarAnimalAPotrero(string idAnimal, int idPotrero)
        {
            try
            {

                if (idAnimal != null && idPotrero != null)
                {
                    Potrero potreroBuscado = miSistema.BuscarPotrero(idPotrero);
                    Ganado animalBuscado = miSistema.BuscarAnimal(idAnimal);

                    if (potreroBuscado != null && animalBuscado != null)
                    {

                        if (animalBuscado is Bovino bovino)
                        {
                            bovino.ValidarDatos();
                            potreroBuscado.AgregarGanado(bovino);
                            TempData["Mensaje"] = "Animal bovino agragado correctamente al potrero";
                            return RedirectToAction("AsignarAnimalAPotrero", "Capataz");
                        }
                        else if (animalBuscado is Ovino ovino)

                        {
                            ovino.ValidarDatos();
                            potreroBuscado.AgregarGanado(ovino);
                            TempData["Mensaje"] = "Animal ovino agragado correctamente al potrero";
                            return RedirectToAction("AsignarAnimalAPotrero", "Capataz");


                        }
                    }
                    else
                    {
                        ViewBag.Mensaje = "Potrero o animal invalido";
                    }

                }

            }

            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;

            }
            ViewBag.Mensaje = "Potrero con datos nulos";
            return View("AsignarAnimalAPotrero");
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
        public IActionResult ListadoDePotreros()
        {
            ViewBag.Potreros = miSistema.Potreros;
            return View();
        }
    }
}
