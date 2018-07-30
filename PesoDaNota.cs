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
            double p1, p2, p3, mediaFinal;

            // LENDO OS VALORES
            // LENDO E ARMAZENANDO O VALOR DA PRIMEIRA NOTA
            Console.WriteLine("======================================================");
            Console.WriteLine("===== SISTEMA PESO DAS NOTAS =====");
            Console.Write("Digite o valor da Primeira Nota: ");
            p1  = Double.Parse(Console.ReadLine());

            // LENDO E ARMAZENANDO O VALOR DA SEGUNDA NOTA
            Console.Write("Digite o valor da Segunda Nota: ");
            p2 = Double.Parse(Console.ReadLine());

            // LENDO E ARMAZENANDO O VALOR DA TERCEIRA NOTA
            Console.Write("Digite o valor da Terceira Nota: ");
            p3 = Double.Parse(Console.ReadLine());
            Console.WriteLine("======================================================");

            // CALCULANDO OS PESOS DAS NOTAS
            p1 = (p1 * 2) / 10;
            p2 = (p2 * 3) / 10;
            p3 = (p3 * 5) / 10;

            // CALCULANDO A MEDIA
            mediaFinal = p1 + p2 + p3;
            
            // ESCREVENDO OS VALORES DAS SOMAS
            Console.WriteLine("======================================================");
            Console.WriteLine("===== RESULTADO =====");
            Console.WriteLine("O valor da Primeira Nota é de: " + p1);
            Console.WriteLine("O valor da Segunda Nota é de: " + p2);
            Console.WriteLine("O valor da Terceira Nota é de: " + p3);
            Console.WriteLine("A Média Final é: " + mediaFinal);
            Console.WriteLine("======================================================");
            Console.ReadLine();
        }
    }
}
