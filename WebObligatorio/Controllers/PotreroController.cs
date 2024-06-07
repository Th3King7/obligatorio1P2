using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{
    public class PotreroController : Controller
    {
        private Sistema miSistema = Sistema.Instancia;
        public IActionResult ListadoDePotreros()
        {
            ViewBag.Potreros = miSistema.Potreros;
            return View();
        }
    }
}
