using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // INCLUSÃO DESSA BIBLIOTECA

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARANDO AS VARIÁVEIS
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            // TRABALHANDO COM TEXTO
            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Turma MT - Senac Vila Prudente");
            Console.WriteLine("Seu nome aqui...");

            // TRABALHANDO COM OS VALORES DE UMA VARIÁVEL
            // UTILIZANDO A BIBLIOTECA SYSTEM.GLOBALIZATION
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            // ALTERANDO O SISTEMA DE PONTUAÇÃO DE VÍRGULA PARA PONTO
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x.ToString("F4", CultureInfo.InvariantCulture));

            // CONCATENANDO TEXTO COM VARIÁVEIS
            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            // INFORMA AO SISTEMA QUE O PROGRAMA SÓ SERÁ ENCERRADO
            // QUANDO O USUÁRIO APERTAR ALGUMA TECLA
            Console.ReadLine();

        }
    }
}
