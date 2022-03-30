using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio47
    {
        static void Main47(string[] args)
        {
            uint[] numeros = new uint[10];
            uint num;
            int maior = 0;
            int menor = 0;
            int igual = 0;

            for (int i=0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite um número inteiro positivo para a posição {i} do vetor: ");
                numeros[i] = Convert.ToUInt32(Console.ReadLine());
            }
            Console.WriteLine("\nDigite um número inteiro positivo: ");
            num = Convert.ToUInt32(Console.ReadLine());

            foreach(var x in numeros)
            {
                if(x > num)
                {
                    maior++;
                    
                }
                else if (x < num)
                {
                    menor++;
                }
                else
                {
                    igual++;
                }
            }
            Console.WriteLine($"{maior} números são maiores que o número {num}");
            Console.WriteLine($"{menor} números são menores que o número {num}");
            Console.WriteLine($"{igual} números são iguais ao número {num}");
        }
    }
}
