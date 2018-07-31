using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaSexo
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, notaUm, notaDois, notaTres, notaQuatro;
            string nomeDoAluno, nomeDoPai, nomeDaMae;
            char sexoDoAluno;

            // CONFIGURANDO O HEADER DO SISTEMA
            Console.WriteLine("====================");
            Console.WriteLine("Sistema da Escola XYZ");
            Console.WriteLine("====================");

            // RECEBENDO OS DADOS DO ALUNO
            Console.Write("Digite o nome do Aluno: ");
            nomeDoAluno = Console.ReadLine();

            Console.Write("Digite o sexo do Aluno(M/F): ");
            sexoDoAluno = Char.Parse(Console.ReadLine());

            Console.Write("Digite o nome do Pai: ");
            nomeDoPai = Console.ReadLine();

            Console.Write("Digite o nome da Mãe: ");
            nomeDaMae = Console.ReadLine();

            // RECEBENDO AS NOTAS
            Console.Write("Digite a Primeira Nota: ");
            notaUm = Double.Parse(Console.ReadLine());

            Console.Write("Digite a Segunda Nota: ");
            notaDois = Double.Parse(Console.ReadLine());

            Console.Write("Digite a Terceira Nota: ");
            notaTres = Double.Parse(Console.ReadLine());

            Console.Write("Digite a Quarta Nota: ");
            notaQuatro = Double.Parse(Console.ReadLine());
            Console.WriteLine("====================");

            // LIMPA A TELA DO CONSOLE
            Console.Clear();

            // CALCULANDO A MÉDIA
            media = (notaUm + notaDois + notaTres + notaQuatro) / 4;

            // IMPRIMINDO OS VALORES NA TELA - NOTA DE CORTE - 6
            Console.WriteLine("======================================");
            Console.WriteLine("Escola XYZ - Resultados do Aluno");
            Console.WriteLine("======================================");
            // apresente o nome do aluno
            Console.WriteLine(" ");
            Console.WriteLine("O aluno " + nomeDoAluno);
            Console.WriteLine("O aluno teve média: " + media);
            Console.WriteLine(" ");
            Console.WriteLine("Notas do ano: ");
            Console.WriteLine(" ");
            Console.WriteLine("Primeira nota: " + notaUm);
            Console.WriteLine("Segunda nota: " + notaDois);
            Console.WriteLine("Terceira nota: " + notaTres);
            Console.WriteLine("Quarta nota: " + notaQuatro);
            Console.WriteLine(" ");


            if (media >= 6){
                Console.WriteLine("O aluno foi APROVADO!");
                Console.WriteLine("======================================");
                Console.WriteLine(nomeDoPai+" e " + nomeDaMae+",");
                Console.WriteLine("Parabéns pelo ótimo trabalho desenvolvido com o(a), " + nomeDoAluno);
                Console.WriteLine("======================================");
            } else{
                Console.WriteLine("O aluno foi REPROVADO!");
                Console.WriteLine("======================================");
                Console.WriteLine(nomeDoPai + " e " + nomeDaMae + ",");
                Console.WriteLine("Vamos trabalhar mais com o(a), " + nomeDoAluno + " para que ele(a) se recupere!");
                Console.WriteLine("======================================");
            }
 
            Console.WriteLine("================================================");
            Console.WriteLine(" Aperte qualquer tecla para encerrar o sistema! ");
            Console.WriteLine("================================================");

            Console.ReadLine();


        }
    }
}
