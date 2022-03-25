using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio33
    {
        static void Main33(string[] args)
        {
            int qtdAlunos;
            string matricula;
            double media;
            double notaProva;
            double somaNotas = 0;

            Console.WriteLine("Quantos alunos há na sala? ");
            qtdAlunos = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= qtdAlunos; i++)
            {
                Console.WriteLine($"\nDigite a matricula do {i}º aluno(a): ");
                matricula = Console.ReadLine();
                Console.WriteLine($"Digite a nota da prova do {i}º aluno(a): ");
                notaProva = Convert.ToDouble(Console.ReadLine());
                somaNotas += notaProva;
            }
            media = somaNotas / qtdAlunos;
            Console.WriteLine($"A média da turma é {media}");
        }
    }
}
