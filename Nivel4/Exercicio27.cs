using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    internal class Exercicio27
    {
        static void Main27(string[] args)
        {
            int qtdNumero, numero, fatorial = 1, num;

            Console.WriteLine("Digite a quantidade de números que deverá ser processados: ");
            qtdNumero = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= qtdNumero; i++)
            {
                Console.WriteLine($"Digite o {i}º número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero >= 0)
                {
                    num = numero;
                    Console.Write($"{num}! = ");
                    while (numero > 1)
                    {
                        fatorial *= numero;
                        Console.Write($"{numero} x ");
                        numero--;
                    }
                    Console.Write($"1 => {fatorial}");
                    fatorial = 1;
                }
                else 
                {
                    Console.WriteLine("Não existe fatorial de número negativo !!");
                }
            }
        }
        
    }
}
