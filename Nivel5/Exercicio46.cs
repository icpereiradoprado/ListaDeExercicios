using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    internal class Exercicio46
    {
        static void Main46(string[] args)
        {
            int tamanhoVetor;
            int result = 0;
            
            Console.WriteLine("Digite a quantidade de números que você deseja adicionar no vetor: ");
            tamanhoVetor = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[tamanhoVetor];
            int[] y = new int[tamanhoVetor];

            for(int i = 0; i < tamanhoVetor; i++)
            {
                Console.WriteLine("Digite um número para o primeiro vetor: ");
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite um número para o segundo vetor: ");
                y[i] = Convert.ToInt32(Console.ReadLine());

                result+= x[i] * y[i];
            }

            Console.WriteLine($"\nProduto escalar = {result}");
        }
    }
}
