using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio6
    {
        static void Main6(string[] args)
        {
            string C;
            int F;

            Console.WriteLine("Digite a temperatura em ºC");
            C = Console.ReadLine();
            F = ((9 * Convert.ToInt32(C)) + 160)/5;

            Console.WriteLine($"{C}ºC em Fahrenheit é {F}ºF");
        }
    }
}
