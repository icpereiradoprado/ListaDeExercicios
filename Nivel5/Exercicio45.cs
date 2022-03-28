using System;
using System.Collections.Generic;

namespace Nivel5
{
    internal class Exercicio45
    {
        static void Main45(string[] args)
        {
            int qtdElementos;
            Console.WriteLine("Digite a quantidade de números que você deseja adicionar no vetor: ");
            qtdElementos = Convert.ToInt32(Console.ReadLine());
            
            int[] numeros = new int[qtdElementos];

            for(int i = 0; i < qtdElementos; i++)
            {
                Console.WriteLine($"Digite o {i}º número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(var j in numeros)
            {
                Console.WriteLine($"Lista original: {j}");
            }

            Array.Reverse(numeros);
            foreach (var k in numeros)
            {
                Console.WriteLine($"Lista invertida: {k}");
            }
            
        }
    }
}
