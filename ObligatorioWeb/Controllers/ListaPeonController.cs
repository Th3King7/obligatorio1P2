using Microsoft.AspNetCore.Mvc;

namespace ObligatorioWeb.Controllers
{
    public class ListaPeonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
