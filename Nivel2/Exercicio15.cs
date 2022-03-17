using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio15
    {
        static void Main15(string[] args) 
        {
            double nota1, nota2, nota3, nota4, notaRecuperacao, media;

            Console.WriteLine("Digite a 1º nota do aluno: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a 2º nota do aluno: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a 3º nota do aluno: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a 4º nota do aluno: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine($"Aluno aprovado!!\nSua média é: {media}");
            }
            else
            {
                Console.WriteLine("Aluno de Recuperação...\nDigite a nota de recuperação do aluno: ");
                notaRecuperacao = Convert.ToDouble(Console.ReadLine());
                media = (nota1 + nota2 + nota3 + nota4 + notaRecuperacao) / 5;
                if (media >= 7)
                {
                    Console.WriteLine($"Aluno aprovado na recuperação!!\nSua média é: {media}");
                }
                else 
                {
                    Console.WriteLine($"Aluno reprovado!!\nSua média é: {media}");
                }
            }
        }
    }
}
