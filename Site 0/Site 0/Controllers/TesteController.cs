using Microsoft.AspNetCore.Mvc;

namespace Site_0.Controllers;

public class Result
{
    public string Texto = string.Empty;
    public string Cifra = string.Empty;
}

public class TesteController : Controller
{
    private readonly ILogger<TesteController> _logger;
    public TesteController(
        ILogger<TesteController> logger 
    )
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View("Index", new Result());
    }

    [HttpPost]
    public IActionResult Index(string texto, string cifra)
    {
        Result resultado = new();
        if(!string.IsNullOrEmpty(texto)) resultado.Texto = texto.ToUpper();
        if(!string.IsNullOrEmpty(cifra)) resultado.Cifra = cifra.ToUpper();

        return View("Index", resultado);
    }
}
