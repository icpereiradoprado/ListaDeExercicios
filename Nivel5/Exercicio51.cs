using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio51
    {
        static void Main51(string[] args)
        {
            uint quantidadeAlunos;
            Console.WriteLine("Digite a quantidade de alunos da sala: ");
            quantidadeAlunos = Convert.ToUInt32(Console.ReadLine());
            
            double[] notas = new double[quantidadeAlunos];
            int contNotaBaixa = 0;
            int contNotaAlta = 0;
            double somaNota = 0;
            double media;


            for(int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Digite a nota do " + (i + 1) + "º aluno:");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            foreach(var x in notas)
            {
                somaNota += x;

                if(x < 5.0)
                {
                    contNotaBaixa++;
                }else if(x > 7.0)
                {
                    contNotaAlta++;
                }
                
                if(contNotaBaixa == quantidadeAlunos)
                {
                    Console.WriteLine("\nNão há nenhum aluno com nota acima de 5.");
                }
            }
            media = somaNota / quantidadeAlunos;
            media = Math.Round(media,2);
            
            Console.WriteLine($"\nA média aritimética da sala é {media}\nQuantidade de alunos com a nota acima de 7.0: {contNotaAlta}");
        }
    } 
}
