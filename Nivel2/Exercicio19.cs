using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio19
    {
        static void Main19(string[] args)
        {
            double a, b, c, soma1, soma2, soma3;

            Console.WriteLine("Digite o valor do lado A do triângulo: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B do triângulo: ");
            b= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C do triângulo: ");
            c = Convert.ToDouble(Console.ReadLine());

            soma1 = a + b;
            soma2 = a + c;
            soma3 = b + c;

            if (soma1 > c && soma2 > b && soma3 > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os lados fornecidos não caracterizam um Triângulo");
            }
        }
    }
}
