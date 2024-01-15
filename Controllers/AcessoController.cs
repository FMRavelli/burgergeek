using GameStation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace GameStation.Controllers
{
    public class AcessoController : Controller
    {
        private readonly ILogger<AcessoController> _logger;

        public AcessoController(ILogger<AcessoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View("EmBreve");
        }

        public IActionResult Registrar()
        {
            return View();
        }
        
        public IActionResult Esqueceusenha()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
