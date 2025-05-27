using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Veterinária_Classes.Models;

namespace Veterinária_Classes.Controllers
{
    public class Clinica
    { }
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public void Retornar() { }
        public void Salvar() { }
    }

    public class Consultas
    { 
        public int AnimalId { get; set; }
        public string Date { get; set; }
        public string Procedure { get; set; }
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
