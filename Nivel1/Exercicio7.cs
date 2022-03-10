using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio7
    {
        static void Main(string[] args) 
        {
            string F;
            int C;

            Console.WriteLine("Digite a temperatura em ºF");
            F = Console.ReadLine();

            C = (Convert.ToInt32(F) - 32) * 5/9;

            Console.WriteLine($"{F}ºF em Celsius é {C}ºC");
        }
    }
}
