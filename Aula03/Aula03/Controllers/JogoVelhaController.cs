using Microsoft.AspNetCore.Mvc;

namespace Aula03.Controllers
{
    public class JogoVelhaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(
                string A00, string A01, string A02,
                string A10, string A11, string A12,
                string A20, string A21, string A22
        )
        {
            string[,] matrixJV = new string[3, 3];
            matrixJV[0, 0] = A00;
            matrixJV[0, 1] = A01;
            matrixJV[0, 2] = A02;

            matrixJV[1, 0] = A10;
            matrixJV[1, 1] = A11;
            matrixJV[1, 2] = A12;

            matrixJV[2, 0] = A20;
            matrixJV[2, 1] = A21;
            matrixJV[2, 2] = A22;

            int acertosLinhaX= 0;
            int acertosColunaX= 0;
            int acertosDiagonalX = 0;
            int acertosDiagonalInvertidaX = 0;
            int acertosLinhaO = 0;
            int acertosColunaO = 0;
            int acertosDiagonalO = 0;
            int acertosDiagonalInvertidaO = 0;

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    // Colunas
                    if (matrixJV[j, i] == "X")
                    {
                        acertosColunaX++;
                    }
                    if (matrixJV[j, i] == "O")
                    {
                        acertosColunaO++;
                    }
                    // Linhas
                    if (matrixJV[i, j] == "X")
                    {
                        acertosLinhaX++;
                    }
                    if (matrixJV[i, j] == "O")
                    {
                        acertosLinhaO++;
                    }
                    // Diagonal
                    if (i == j)
                    {
                        if (matrixJV[i,j] == "X")
                        {
                            acertosDiagonalX++;
                        }
                        if (matrixJV[i, j] == "O")
                        {
                            acertosDiagonalO++;
                        }
                    }
                    // Diagonal Inversa
                    if (i + j == 2)
                    {
                        if (matrixJV[i, j] == "X")
                        {
                            acertosDiagonalInvertidaX++;
                        }
                        if (matrixJV[i, j] == "O")
                        {
                            acertosDiagonalInvertidaO++;
                        }
                    }
                }

                // Conferir acertos na linha
                if (acertosColunaX == 3)
                {
                    return "X ganhou pelas colunas!";
                }
                else if (acertosColunaO == 3)
                {
                    return "O ganhou pelas colunas!";
                }

                // Conferir acertos na coluna
                if (acertosLinhaX == 3)
                {
                    return "X ganhou pelas linhas!";
                }
                else if (acertosLinhaO == 3)
                {
                    return "O ganhou pelas linhas!";
                }

                // Conferir acertos na diagonal
                if (acertosDiagonalX == 3 || acertosDiagonalInvertidaX == 3)
                {
                    return "X ganhou pela diagonal";
                }
                if (acertosDiagonalO == 3 || acertosDiagonalInvertidaO == 3)
                {
                    return "O ganhou pela diagonal";
                }

                acertosLinhaX = 0;
                acertosLinhaO = 0;

                acertosColunaX = 0;
                acertosColunaO = 0;
            }

            return $"Marquei Linha X: {acertosLinhaX} \n " +
                   $"Marquei Coluna X: {acertosColunaX} \n " +
                   $"Marquei Diagonal X: {acertosDiagonalInvertidaX} \n " +
                   $"Marquei Diagonal Invertida X: {acertosDiagonalX} \n " +
                   $"Marquei Linha O: {acertosLinhaO} \n " + 
                   $"Marquei Coluna O: {acertosColunaO} \n " + 
                   $"Marquei Diagonal O: {acertosDiagonalO} \n " + 
                   $"Marquei Diagonal Invertida O: {acertosDiagonalInvertidaO} \n ";
        }
    }
}
