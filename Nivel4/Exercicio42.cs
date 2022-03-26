using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    internal class Exercicio42
    {
        static void Main42(string[] args)
        {
            int numero;
            int cont = 0;
            int maior = 0;
            int menor = 0;
            while(true)
            {
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                cont ++;
                if(cont == 1)
                {
                    maior = numero;
                    menor = numero;
                }
                if(numero == 0)
                {
                    break;
                }
                else if(numero > maior)
                {
                    maior = numero;
                }
                else if (numero < menor)
                {
                    menor = numero;
                }
            }
            Console.WriteLine($"O maior número entre os digitados é {maior}\nO menor número entre os digitados é {menor}");
        }
    }
}
