/*===================================================================================================
## FUNCIONALIDADE
    ALGORITMO QUE LÊ O VALOR DIGITADO PELO USUÁRIO E SOMA O VALOR AO VALOR QUE TEMOS EM CONTA. 
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
            double saldo, chequeDepositado;

            // ATRIBUINDO O VALOR A VARIÁVEL SALDO
            saldo = 1000;

            // PEDINDO AO USUÁRIO QUE DIGITE O VALOR DO CHEQUE
            Console.Write("Digite o valor do cheque depositado: ");
            chequeDepositado = Double.Parse(Console.ReadLine());

            // ATUALIZANDO O VALOR DO SALDO
            saldo = saldo + chequeDepositado;

            // APRESENTANDO O VALOR ATUALIZADO
            Console.WriteLine("O saldo atualizado da conta é de: R$ " + saldo + " reais");

            Console.ReadLine();
        }
    }
}
