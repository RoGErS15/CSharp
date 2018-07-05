/*===================================================================================================
## FUNCIONALIDADE
    ALGORITMO CRIADO PARA FUNCIONAR RECEBENDO QUATRO NOTAS DE UM ALUNO
    CALCULANDO A MÉDIA E APRESENTANDO O VALOR NA TELA.
===================================================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, notaUm, notaDois, notaTres, notaQuatro;

            Console.Write("Digite a primeira nota: ");
            notaUm = Double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            notaDois = Double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            notaTres = Double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            notaQuatro = Double.Parse(Console.ReadLine());

            media = (notaUm + notaDois + notaTres + notaQuatro) / 4;

            Console.Write("O aluno teve média: " + media);

            Console.ReadLine();
        }
    }
}
