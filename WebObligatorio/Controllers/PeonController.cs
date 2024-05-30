using Microsoft.AspNetCore.Mvc;

namespace WebObligatorio.Controllers
{
    public class PeonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
