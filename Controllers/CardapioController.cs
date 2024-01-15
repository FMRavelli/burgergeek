using GameStation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace GameStation.Controllers
{
    public class CardapioController : Controller
    {
        private readonly ILogger<CardapioController> _logger;

        public CardapioController(ILogger<CardapioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
