using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{
    public class TareaController : Controller
    {
        private Peon miPeon = Peon.Instancia;
        public IActionResult Index()
        {
            ViewBag.Tareas = miPeon.ListadoTareasPeones();
            return View();
        }
    }
}
