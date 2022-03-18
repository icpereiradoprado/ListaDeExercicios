using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio28
    {
        static void Main28(string[] args) 
        {
            int intervaloInicial, intervaloFinal = 0,impar;

            Console.WriteLine("Digite um número inteiro entre 100 e 200 para o intervalo inicial: ");
            intervaloInicial = Convert.ToInt32(Console.ReadLine());
            if (intervaloInicial < 100 || intervaloInicial > 200)
            {
                Console.WriteLine("Valor para o intervalo inicial inválido!!");
            }
            else 
            {
                Console.WriteLine($"Digite um número inteiro entre {intervaloInicial} e 200 para o intervalo final: ");
                intervaloFinal = Convert.ToInt32(Console.ReadLine());
                if(intervaloFinal < intervaloInicial || intervaloFinal > 200)
                {
                    Console.WriteLine("Valor para o intervalo final inválido!!");
                }
                else
                {
                    for (int i = intervaloInicial; i <= intervaloFinal; i++)
                    {
                        if (i % 2 == 1)
                        {
                            impar = i;
                            Console.WriteLine($"Números ímpares {impar}");
                        }
                    }
                }
            }
        }
    }
}
