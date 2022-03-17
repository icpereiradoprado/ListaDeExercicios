using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio12
    {
        static void Main12(string[] args)
        {
            int x;

            Console.WriteLine("Digite um número inteiro: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x >= 0)
            {
                Console.WriteLine($"O módulo de {x} é {x}");
            }
            else 
            {
                Console.WriteLine($"O módulo de {x} é {x * -1}");
            }
        }
    }
}
