using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio56
    {
        static void Main56(string[] args)
        {
            uint[] numeros = new uint[50];
            int contadorPares = 0;
            int contadorMultiplo5 = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro e positivo para a " + (i + 1) + "º posição do vetor");
                numeros[i] = Convert.ToUInt32(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    contadorPares++;
                }
                if (numeros[i] % 5 == 0)
                {
                    contadorMultiplo5++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {contadorPares}\nQuantidade de números múltiplos de 5: {contadorMultiplo5}");
        }
    }
}
