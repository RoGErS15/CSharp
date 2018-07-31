using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  CÓDIGO UTILIZADO PARA VERIFICAR SE O SEXO INFORMADO É MASCULINO OU FEMININO. 
  TESTAMOS OS CONHECIMENTOS DO ALUNO COM RELAÇÃO AOS COMANDOS CONSOLE.WRITE, CONSOLE.WRITELINE, CONSOLE.READLINE 
  E PRINCIPALMENTE A UTILIZAÇÃO FUNÇÃO SE
*/

namespace VerificaSexo
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARANDO AS VARIÁVEIS
            char sexo;

            // RECEBENDO OS VALORES 
            Console.Write("Digite o sexo(M/F): ");
            sexo = char.Parse(Console.ReadLine());

            // VERIFICA SE O VALOR INFORMADO É MASCULINO OU FEMININO
            if (sexo == 'F'){
                // CASO A CONDIÇÃO SEJA VERDADEIRA
                Console.WriteLine("O sexo informado é Feminino");
            } else  {
                // CASO A CONDIÇÃO SEJA FALSA
                Console.WriteLine("O sexo informado é Masculino");
            }

            // AGUARDA ALGUMA TECLA SER PRESSIONADA PARA ENCERRAR O ENCERRAMENTO
            Console.ReadLine();
        }
    }
}
