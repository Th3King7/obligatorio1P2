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
        //Registramos un bovino en el sistema , recibe de la vista un Objeto bovino con sus respectivas instancias
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
                    TempData["Mensaje"] = "bovino con datos nulos";

                }

            }
            catch (Exception ex)
            {
                TempData["Mensaje"] = ex.Message;

            }
            return View();
        }
        public IActionResult AsignarAnimalAPotrero()
        {

            ViewBag.Potreros = miSistema.Potreros;
            ViewBag.Animales = miSistema.Animales;
            return View();
        }

        [HttpPost]
        //Asignamos un animal libre a un potrero
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
                        TempData["Mensaje"] = "Potrero o animal invalido";
                    }

                }

            }

            catch (Exception ex)
            {
                TempData["Mensaje"] = ex.Message;

            }
            TempData["Mensaje"] = "Potrero con datos nulos";
            return View("AsignarAnimalAPotrero");
        }
  //Creamos lista de peones para que la vea el capataz
        public IActionResult ListaPeones()
        {
            ViewBag.Empleados = miSistema.EmpleadosPeones();
            return View();
        }
        //El usuario cpataz asigna una tarea a un peon
        public IActionResult AsignarTarea()
        {
            ViewBag.Peones = miSistema.EmpleadosPeones();
            return View();
        }

        [HttpPost]
        public IActionResult AsignarTarea(string emailPeon, string descripcion, DateTime fechaInicio, DateTime fechaCierre)
        {
            try
            {
                if (!string.IsNullOrEmpty(emailPeon) && !string.IsNullOrEmpty(descripcion) && fechaInicio != DateTime.MinValue && fechaCierre != DateTime.MinValue)
                {
                    miSistema.AsignarTareaAPeon(emailPeon, new Tarea(descripcion, fechaInicio, fechaCierre, false, "..."));
                    TempData["Mensaje"] = "Tarea asignada correctamente";
                }
                else
                {
                    TempData["Mensaje"] = "Datos nulos";
                }

            }
            catch (Exception ex)
            {
                TempData["Mensaje"] = ex.Message;
            }
            ViewBag.Peones = miSistema.EmpleadosPeones();
            return View();
        }
        //Mostramos en listado de potreros con su potencial ganancia
        public IActionResult ListadoDePotreros()
        {
            ViewBag.Potreros = miSistema.Potreros;
            foreach (Potrero potrero in ViewBag.Potreros)
            {
                decimal gananciaEstimada = 0;

                // Calcular ganancia estimada para todos los animales en el potrero
                foreach (Ganado animal in potrero.Animales)
                {
                    if (animal is Ovino ovino)
                    {
                        gananciaEstimada += ovino.CalcularPrecioVenta() - ovino.CalcularCostoCrianza();
                    }
                    else if (animal is Bovino bovino)
                    {
                        gananciaEstimada += bovino.CalcularPrecioVenta() - bovino.CalcularCostoCrianza();
                    }


                }
                potrero.GananciaEstimada = gananciaEstimada;
            }
            return View();
        }
       // Mostramos los animales que cumplan con los requisitos de tipo y del peso indicado por el capataz
        public IActionResult BuscarAnimalPorTipoYPeso()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BuscarAnimalPorTipoYPeso(string tipoAnimal, decimal pesoMinimo)
        {
            {

                List<Ganado> animalesFiltrados = new List<Ganado>();

                if (!string.IsNullOrEmpty(tipoAnimal) && pesoMinimo > 0)
                {
                    if (tipoAnimal == "Ovino")
                    {
                        foreach (Ovino ovino in miSistema.ObtenerOvinos())
                        {
                            if (ovino.PesoActual > pesoMinimo)
                            {
                                animalesFiltrados.Add(ovino);
                            }
                        }
                    }
                    else if (tipoAnimal == "Bovino")
                    {
                        foreach (Bovino bovino in miSistema.ObtenerBovinos())
                        {
                            if (bovino.PesoActual > pesoMinimo)
                            {
                                animalesFiltrados.Add(bovino);
                            }
                        }
                    }
                }

                ViewBag.AnimalesFiltrados = animalesFiltrados;
                ViewBag.TipoAnimal = tipoAnimal;
                ViewBag.PesoMinimo = pesoMinimo;

                return View();
            }

        }

    }
}

