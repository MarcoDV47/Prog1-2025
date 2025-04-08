using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aula04Recursividade.Models;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Aula04Recursividade.Controllers;

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

    [HttpGet]
    public string PrintNaturalFor(int n = 10)
    {
        string retorno = string.Empty;

        int i = 1;
        while (i <= n)
        {
            retorno += $" {i} ";
            i++;
        }

        return retorno;
    }

    [HttpGet]
    public string PrintNaturalRecursion(int count = 10)
    {
        string retorno = "";

        retorno = NaturalNumberRecursion(1, count);

        return retorno;
    }

    public string NaturalNumberRecursion(int n, int count)
    {
        string ret = string.Empty;


        // Caso base: onde a recursividade pára
        // Início caso base: Se o contador for menor que 1

        if (count < 1) return $" {n} ";

        // Fim do caso base


        // Caso recursivo: onde faz a recursividade

        ret += $" {n} ";
        count--; // Decrementa count

        //Chamada recursiva: Incrementa n e Decrementa count
        //Para imprimir o número

        ret += NaturalNumberRecursion(n + 1, count);

        return ret;
    }

    public string PrintNegativeNaturalRecursion(int n = 10)
    {
        string retorno = "";

        retorno = NaturalNegativeNumberRecursion(n);

        return retorno;
    }
    public string NaturalNegativeNumberRecursion(int n)
    {
        string ret = string.Empty;

        if (n < 1) return ret;

        ret += $" {n} ";

        ret += NaturalNegativeNumberRecursion(n - 1);

        return ret;
    }

    public int PrintSumRecursion(int count = 10)
    {
        int retorno;

        retorno = SumNumberRecursion(1, count);

        return retorno;
    }

    public int SumNumberRecursion(int n, int count)
    {
        int ret = 0;

        if (count < 1) return ret;

        ret += n;
        count--; 

        ret += SumNumberRecursion(n + 1, count);

        return ret;
    }

    public int PrintSumString(string texto = "exemplo")
    {
        int retorno = 0;
        int tamanho = texto.Length;

        retorno = SumString(0, tamanho);

        return retorno;
    }

    public int SumString(int n, int tamanho)
    {
        int ret = 0;

        if (tamanho < 1) return ret;

        ret++;
        tamanho--;

        ret += SumString(n + 1, tamanho);

        return ret;
    }

    public bool PrintIsPalindrome(string texto = "exemplo")
    {
        string retorno = string.Empty;
        int tamanho = texto.Length;

        retorno = IsPalindrome(tamanho, texto);

        if (retorno == texto) return true ;

        return false;
    }

    public string IsPalindrome(int tamanho, string texto)
    {
        string ret = string.Empty;

        if (tamanho < 1) return ret;

        tamanho--;
        ret += texto[tamanho];

        ret += IsPalindrome(tamanho, texto);

        return ret;
    }
}
