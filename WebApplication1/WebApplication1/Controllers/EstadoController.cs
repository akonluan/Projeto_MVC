using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class EstadoController : Controller
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
