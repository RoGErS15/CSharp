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
            int a, b, y;

            // RECEBENDO OS VALORES 
            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            // TROCANDO OS VALORES DAS VARIÁVEIS
            y = a;
            a = b;
            b = y;

            // IMPRIMINDO OS VALORES NA TELA
            Console.WriteLine("O valor alterado de A é: " + a);
            Console.WriteLine("O valor alterado de B é: " + b);

            // AGUARDA ALGUMA TECLA SER PRESSIONADA PARA ENCERRAR O ENCERRAMENTO
            Console.ReadLine();
        }
    }
}
