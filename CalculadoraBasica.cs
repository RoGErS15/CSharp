using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesoDaNota
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARANDO AS VARIÁVEIS
            int a, b;

            // RECEBENDO OS VALORES DIGITADOS
            Console.WriteLine("===============================================================");
            Console.WriteLine("===== SUPER CALCULADORA 3000 - ORGANIZAÇÕES TABAJARA ======");
            Console.WriteLine("===============================================================");

            Console.Write("Digite o Primeiro Valor: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo Valor: ");
            b = int.Parse(Console.ReadLine());

            // IMPRIMINDO OS VALORES NA TELA PARA O USUÁRIO
            Console.WriteLine("===============================================================");
            Console.WriteLine("===== RESULTADO ======");
            Console.WriteLine("O resultado da soma dos valores digitados é: " + (a + b));
            Console.WriteLine("O resultado da subtração dos valores digitados é: " + (a - b));
            Console.WriteLine("O resultado da multiplicação dos valores digitados é: " + (a * b));
            Console.WriteLine("O resultado da divisão dos valores digitados é: " + (a / b));
            Console.WriteLine("===============================================================");

            // AGUARDA ALGUMA TECLA SER PRESSIONADA PARA ENCERRAR O ENCERRAMENTO
            Console.ReadLine();

        }
    }
}
