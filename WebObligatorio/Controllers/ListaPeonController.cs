using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{
    public class ListaPeonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
