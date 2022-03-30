using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio49
    {
        static void Main49(string[] args)
        {
            uint tamanhoVetor;
            Console.WriteLine("Digite o tamanho do vetor.\n\tTamanho MÁXIMO: 50");
            tamanhoVetor = Convert.ToUInt32(Console.ReadLine());
            if(tamanhoVetor >= 0 && tamanhoVetor <= 50)
            {
                int[] v1 = new int[tamanhoVetor];
                int[] v2 = new int[tamanhoVetor];

                for(int i = 0; i < tamanhoVetor; i++)
                {
                    Console.WriteLine("Digite um número inteiro para a posição "+ (i+1) +" do vetor V1: ");
                    v1[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Digite um número inteiro para a posição " + (i + 1) +" do vetor V2: ");
                    v2[i] = Convert.ToInt32(Console.ReadLine());
                    if(v1[i] == v2[i])
                    {
                        Console.WriteLine($"\nO valor {v1[i]} da posição "+(i+1)+$" do vetor V1 é indêntico ao valor {v2[i]} da posição "+(i+1)+" do vetor V2\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("Tamanho do vetor inválido...");
            }

            
        }
    }
}
