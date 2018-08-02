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
            int contador;

            // FUNÇÃO FOR SENDO UTILIZADA PARA FAZER UM VERIFICAÇÃO E APRESENTAR OS NÚMEROS PARES EM UM INTERVALO DE 0 ATÉ 100
            Console.WriteLine();
            Console.WriteLine("Para saber os números pares no intervalo de 0 até 100");
            for (contador = 0; contador <= 100; contador += 2){
                Console.WriteLine("O intervalo contém: " + contador);
            }

            // FUNÇÃO FOR SENDO UTILIZADA PARA FAZER UM VERIFICAÇÃO E APRESENTAR OS NÚMEROS ÍMPARES EM UM INTERVALO DE 0 ATÉ 100
            Console.WriteLine();
            Console.WriteLine("Para saber os números ímpares no intervalo de 0 até 100");
            for (contador = 1; contador <= 100; contador += 2){
                Console.WriteLine("O intervalo contém: " + contador);
            }

            Console.ReadLine();
        }
    }
}
