using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ConversorNúmeros.Models;

namespace ConversorNúmeros.Controllers;
public class Result
{
    public string WritenNumber = string.Empty;
    public int toConvertNumber = 1;
}
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View("Index", new Result());
    }

    [HttpPost]
    public IActionResult Index(int numero)
    {
        Result resultado = new();
        Numbers numeros = new();
        resultado.WritenNumber = numeros.WriteNumber(numero);

        return View("Index", resultado);
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
