using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aula03.Models;

namespace Aula03.Controllers;

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
        return View();
    }

    [HttpGet]
    public string GetIf(int x)
    {
        /*
            Estrutura sintática do IF
            if(expressão booleana)
            {
                Sentença de código
                a ser executada, caso   
                a condição seja 
                verdadeira
            }

            Caso o if tenha apenas uma 
            linha de comando a ser executada
            na condicional, não precisamos
            colocar chaves

            if(expressão booleana) 
                Apenas um comando
            
        */

        string retorno = string.Empty;
        //int x = 10;

        if (x < 9) retorno = "x é menor que 9";

        //x = 8;

        if (x > 9) retorno = "x é maior que 9";
        else retorno = "x é menor que 9";

        //x = 11;

        if (x == 10)
        {
            retorno = "Ora ora ";
            retorno += "X é igual a 10";
        }
        else if (x == 9)
        {
            retorno = "Hmmmmmm ";
            retorno = "x é igual a 9";
        }
        else if (x == 9)
        {
            retorno = "Bahhhhh ";
            retorno = "x é igual a 8, tchê";
        }
        else retorno = "Sei lá que número é x";

        return retorno;
    }

    [HttpGet]
    public string GetSwitch(int x)
    {
        string retorno;

        switch(x)
        {
            case 0:
                retorno = "x é zero";
                break;
            case 1:
                retorno = "x é um";
                break;
            case 2:
                retorno = "x é dois";
                break;
            case 3:
                retorno = "x é três";
                break;
            default:
                retorno = "x é algum número não previsto";
                break;
        }

        return retorno;
    }

    [HttpGet]
    public string GetFor(int x)
    {
        /*
            O comando de repetição For possui a seguinte sintaxe:

            for(<inicializador>; <expressão condicional>; <expressão de repetição)
            {
                Comandos a serem executados
            }

            Inicializador: elemento contador. Tradicioanlemente utilizado o i = índice;
            Expressão condicional: Especifica o teste a ser verificado quando o loop 
                estiver executado o número definido de iterações (flag);
            Expressão de repetição: Especifica a ação a ser executada com a variável contadora.
                Geralmente um acúmulo ou decréscimo (acumulador);
        */

        string retorno = string.Empty;

        for (int i = 0; i <= x; i++)
        {
            /*
                E se eu quisesse interromper o laço
                caso ele fosse maior que 50
            */

            if (i > 5) break; // O comando break sai do laço

            // Se eu quissesse continuar o laço
            if (i % 2 != 0) continue;

            retorno += $"{i}; ";
        }

        return retorno;
    }

    public string GetForeach(string color)
    {
        /*
            O comando foreach (para cada) é utilizado para 
            iterar por uma sequência de itens em uma
            coleção e servir como uma opção simples de repetição.
        */

        string[] colors = 
        {
            "Vermelho", "Preto", "Azul", 
            "Verde", "Branco", "Amarelo",
            "Rosa", "Roxo", "Cinza", "Azul-Marinho"
        };

        string retorno = string.Empty;

        if (colors.Contains(char.ToUpper(color[0]) + color.Substring(1)))
            retorno = "A cor escolhida é válida.";
        else
            retorno = "Cor escolhida inválida.";

        foreach (string s in colors)
        {
            retorno += $" [{s}] ";
        }

        return retorno;
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
