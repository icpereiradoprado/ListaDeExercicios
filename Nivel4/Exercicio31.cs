using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio31
    {
        static void Main31(string[] args)
        {
            int numerosPositivos,par = 0,impar = 0;

            while (true)
            {
                Console.WriteLine("Digite um número inteiro positivo: \n");
                numerosPositivos = Convert.ToInt32(Console.ReadLine());
                if(numerosPositivos < 0)
                {
                    break;
                }
                else if (numerosPositivos % 2 == 0)
                {
                    Console.WriteLine($"O número {numerosPositivos} é par\n");
                    par += numerosPositivos;
                }
                else
                {
                    Console.WriteLine($"O número {numerosPositivos} é ímpar\n");
                    impar += numerosPositivos;
                }
                Console.WriteLine("\n===================================\nDeseja para a execução?\nSe sim, digite um número negativo\n===================================\n");
            }
            
            Console.WriteLine($"\nA soma dos números pares é {par}");
            Console.WriteLine($"\nA soma dos números ímpares é {impar}");
        }
    }
}
