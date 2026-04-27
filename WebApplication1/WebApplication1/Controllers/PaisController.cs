using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PaisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detalhes()
        {
            return View();
        }
    }
}
