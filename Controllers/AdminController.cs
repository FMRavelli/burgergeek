using GameStation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace GameStation.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Segredo(string senha)
        {
            // Verifica se a senha está correta (coloque sua lógica de autenticação aqui)
            if (senha == "EuTeAmo")
            {
                return View();
            }
            else
            {
                // Senha incorreta, redireciona de volta para a página de login
                return RedirectToAction("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
