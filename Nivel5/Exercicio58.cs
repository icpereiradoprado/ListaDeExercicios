using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio58
    {
        static void Main58(string[] args)
        {
            uint tamanhoVetor;
            uint maior = 0;
            double somaNumeros = 0.0;
            double media;
            Console.WriteLine("Digite o tamanho do vetor");
            tamanhoVetor = Convert.ToUInt32(Console.ReadLine());

            uint[] numeros = new uint[tamanhoVetor];

            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.WriteLine("Digite um número inteiro e positivo para a " + (i + 1) + "º posição do vetor");
                numeros[i] = Convert.ToUInt32(Console.ReadLine());
                if (i == 0)
                {
                    maior = numeros[i];
                }
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }

                somaNumeros += numeros[i];
            }
            media = somaNumeros / tamanhoVetor;
            media = Math.Round(media, 2);
            Console.WriteLine($"O maior número é {maior}\nA média dos números é: {media}");

        }
    }
}
