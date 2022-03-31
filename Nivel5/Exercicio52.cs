using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio52
    {
        static void Main52(string[] args)
        {
            int tamanhoVetor = 100;
            int[] numeros = new int[tamanhoVetor];
            int num;
            int contador = 0;
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Digite -1 para encerrar o programa.\nDigite um número inteiro e positivo para a " + (i + 1) + "º posição do vetor");
                num = Convert.ToInt32(Console.ReadLine());

                if(num == -1)
                {
                    i = 100;
                    tamanhoVetor = i;
                }
                else
                {
                    numeros[i] = num;
                }
            }

            for(int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] == 1 && numeros[i+1] == 3 && numeros[i + 2] == 4)
                {
                    contador++;
                }
            }

            Console.WriteLine($"A sequência 1, 3, 4 aconteceu {contador} vezes");


        }
    }
}
