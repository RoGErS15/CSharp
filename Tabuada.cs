using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int formula, contador, numero;

            Console.Write("Digite o Numero para Obter a Tabuada : ");
            numero = Int32.Parse(Console.ReadLine());

            //FUNÇÃO FOR SENDO UTILIZADA PARA FAZER UMA TABUADA
            for (contador = 1; contador <= 10; ++contador){
                formula = numero * contador;
                Console.WriteLine(numero + " X " + contador + " = " + formula);
            }
            Console.ReadLine();
        }
    }
}
