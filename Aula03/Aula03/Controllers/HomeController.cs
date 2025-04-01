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
            Estrutura sint�tica do IF
            if(express�o booleana)
            {
                Senten�a de c�digo
                a ser executada, caso   
                a condi��o seja 
                verdadeira
            }

            Caso o if tenha apenas uma 
            linha de comando a ser executada
            na condicional, n�o precisamos
            colocar chaves

            if(express�o booleana) 
                Apenas um comando
            
        */

        string retorno = string.Empty;
        //int x = 10;

        if (x < 9) retorno = "x � menor que 9";

        //x = 8;

        if (x > 9) retorno = "x � maior que 9";
        else retorno = "x � menor que 9";

        //x = 11;

        if (x == 10)
        {
            retorno = "Ora ora ";
            retorno += "X � igual a 10";
        }
        else if (x == 9)
        {
            retorno = "Hmmmmmm ";
            retorno = "x � igual a 9";
        }
        else if (x == 9)
        {
            retorno = "Bahhhhh ";
            retorno = "x � igual a 8, tch�";
        }
        else retorno = "Sei l� que n�mero � x";

        return retorno;
    }

    [HttpGet]
    public string GetSwitch(int x)
    {
        string retorno;

        switch(x)
        {
            case 0:
                retorno = "x � zero";
                break;
            case 1:
                retorno = "x � um";
                break;
            case 2:
                retorno = "x � dois";
                break;
            case 3:
                retorno = "x � tr�s";
                break;
            default:
                retorno = "x � algum n�mero n�o previsto";
                break;
        }

        return retorno;
    }

    [HttpGet]
    public string GetFor(int x)
    {
        /*
            O comando de repeti��o For possui a seguinte sintaxe:

            for(<inicializador>; <express�o condicional>; <express�o de repeti��o)
            {
                Comandos a serem executados
            }

            Inicializador: elemento contador. Tradicioanlemente utilizado o i = �ndice;
            Express�o condicional: Especifica o teste a ser verificado quando o loop 
                estiver executado o n�mero definido de itera��es (flag);
            Express�o de repeti��o: Especifica a a��o a ser executada com a vari�vel contadora.
                Geralmente um ac�mulo ou decr�scimo (acumulador);
        */

        string retorno = string.Empty;

        for (int i = 0; i <= x; i++)
        {
            /*
                E se eu quisesse interromper o la�o
                caso ele fosse maior que 50
            */

            if (i > 5) break; // O comando break sai do la�o

            // Se eu quissesse continuar o la�o
            if (i % 2 != 0) continue;

            retorno += $"{i}; ";
        }

        return retorno;
    }

    public string GetForeach(string color)
    {
        /*
            O comando foreach (para cada) � utilizado para 
            iterar por uma sequ�ncia de itens em uma
            cole��o e servir como uma op��o simples de repeti��o.
        */

        string[] colors = 
        {
            "Vermelho", "Preto", "Azul", 
            "Verde", "Branco", "Amarelo",
            "Rosa", "Roxo", "Cinza", "Azul-Marinho"
        };

        string retorno = string.Empty;

        if (colors.Contains(char.ToUpper(color[0]) + color.Substring(1)))
            retorno = "A cor escolhida � v�lida.";
        else
            retorno = "Cor escolhida inv�lida.";

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
