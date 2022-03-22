using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio32
    {
        static void Main(string[] args)
        {
            int numero,soma=0,quadrado, contador = 0;
            
            do
            {
                Console.WriteLine("Digite um número de 0 a 10: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0 || numero > 10)
                {
                    Console.WriteLine("Valor inválido!!\n");
                }
            } while (numero < 0 || numero > 10);

            while (contador < 20)
            {
                if (numero % 2 != 0)
                {
                    quadrado = numero * numero;
                    soma += quadrado;
                    contador++;
                }
                
                numero++;
            }

            Console.WriteLine($"A soma dos quadrados dos 20 primeiros números inteiros positivos ímpares é:\n{soma}");
        }
    }
}
