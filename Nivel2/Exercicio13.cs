using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio13
    {
        static void Main13(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Digite o 1º número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 2º número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 3º número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine($"Ordem decrescente {num1}, {num2}, {num3}");
            }
            else if (num1 > num2 && num2 < num3 && num1 > num3)
            {
                Console.WriteLine($"Ordem decrescente {num1}, {num3}, {num2}");
            }
            else if (num2 > num3 && num1 > num3)
            {
                Console.WriteLine($"Ordem decrescente {num2}, {num1}, {num3}");
            }
            else if (num2 > num3 && num1 < num3)
            {
                Console.WriteLine($"Ordem decrescente {num2}, {num3}, {num1}");
            }
            else if (num3 > num2 && num1 > num2)
            {
                Console.WriteLine($"Ordem decrescente {num3}, {num1}, {num2}");
            }
            else 
            {
                Console.WriteLine($"Ordem decrescente {num3}, {num2}, {num1}");
            }
        }
    }
}
