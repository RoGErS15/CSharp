/*
NOME: Formulário básico
AUTOR: Adriano Leite da Silva
DATA: 04/07/2018
===================================================================================================
## FUNCIONALIDADE
    ALGORITMO CRIADO PARA FUNCIONAR COMO UM SISTEMA DE CADASTRO BÁSICO
    ONDE O USUÁRIO DIGITA ALGUMAS INFORMAÇÕES E O SISTEMA APRESENTA AS MESMAS INFORMAÇÕES
    NO FINAL DO CONSOLE

## O ALGORITMO TEM COMO PRINCIPAL FUNÇÃO, FAZER COM QUE OS ALUNOS TRABALHEM OS CONHECIMENTOS:
    - DECLARAÇÃO DE VARIÁVEIS;
    - ESTRUTURAR OS COMANDOS DE LEITURA E ESCRITA;
    - PEGAR OS VALORES DIGITADOS PELO USUÁRIO E ATRIBUI-LOS A VARIÁVEL;
    - APRESENTAR OS VALORES QUE FORAM DIGITADOS
===================================================================================================
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RecebeValores
{
    class Program
    {
        static void Main(string[] args)
        {

            // DECLARANDO AS VARIÁVEIS
            string nome, estadoCivil, cidade, endereco, bairro, estado, pais;
            int idade, qdteFilhos;
            double salario;
            char sexo;

            Console.WriteLine("### CADASTRANDO AS INFORMAÇÕES ###");
            Console.WriteLine();
            // RECEBENDO OS VALORES QUE DEVEM SER DIGITADOS PELO USUÁRIO
            // TRABALHANDO COM A VARIÁVEL X - STRING
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            // TRABALHANDO COM A VARIÁVEL Y - INTEIRO
            // O método int.Parse() é usado para converter 
            // uma representação de string de um número em um inteiro.
            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            // TRABALHANDO COM A VARIÁVEL Z - DOUBLE
            Console.Write("Digite a salário - R$ ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // TRABALHANDO COM A VARIÁVEL W - CHAR
            Console.Write("Digite o Sexo(M/F): ");
            sexo = char.Parse(Console.ReadLine());

            // TRABALHANDO COM A VARIÁVEL ESTADO CIVIL
            Console.Write("Digite o estado civil: ");
            estadoCivil = Console.ReadLine();

            // TRABALHANDO COM A VARIÁVEL QUANTIDADE DE FILHOS
            Console.Write("Digite o QUANTIDADE DE FILHOS: ");
            qdteFilhos = int.Parse(Console.ReadLine());

            // TRABALHANDO COM A VARIÁVEL ENDEREÇO
            Console.Write("Digite o ENDEREÇO: ");
            endereco = Console.ReadLine();

            // TRABALHANDO COM A VARIÁVEL BAIRRO
            Console.Write("Digite o BAIRRO: ");
            bairro = Console.ReadLine();

            // TRABALHANDO COM A VARIÁVEL CIDADE
            Console.Write("Digite a CIDADE: ");
            cidade = Console.ReadLine();

            // TRABALHANDO COM A VARIÁVEL ESTADO
            Console.Write("Digite o ESTADO: ");
            estado = Console.ReadLine();

            // TRABALHANDO COM A VARIÁVEL PAÍS
            Console.Write("Digite o PAÍS: ");
            pais = Console.ReadLine();
            
            // APRESENTANDO OS VALORES DIGITADOS
            Console.WriteLine();
            Console.WriteLine("### RESULTADO ###");
            Console.WriteLine();
            Console.WriteLine("O nome digitado foi: " + nome);
            Console.WriteLine("A idade informada foi: " + idade );
            Console.WriteLine("O salário informado foi de R$ " + salario);
            Console.WriteLine("O sexo informado foi: " + sexo);
            Console.WriteLine("O estado civil informado foi: " + estadoCivil);
            Console.WriteLine("Possui : " + qdteFilhos + " filhos.");
            Console.WriteLine("O endereço cadastrado foi: " + endereco);
            Console.WriteLine("O bairro cadastrado é: " + bairro);
            Console.WriteLine("A cidade informada foi: " + cidade);
            Console.WriteLine("O estado informado: " + estado);
            Console.WriteLine("O país cadastrado foi: " + pais);

            Console.ReadLine();
        }
    }
}
