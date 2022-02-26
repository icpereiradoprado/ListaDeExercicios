using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio4
    {
        static void Main4(string[] args)
        {
            int num1, num2, num3, num4;

            Console.WriteLine("Digite o valor do primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro número: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do quarto número: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Soma\n");
            Console.WriteLine($"A+B: {num1 + num2}\nA+C: {num1 + num3}\nA+D: {num1 + num4}\nB+C: {num2 + num3}\nB+D: {num2 + num4}\nC+D: {num3 + num4}");
            Console.WriteLine("\n\nMultiplicação\n");
            Console.WriteLine($"AxB: {num1 * num2}\nAxC: {num1 * num3}\nAxD: {num1 * num4}\nBxC: {num2 * num3}\nBxD: {num2 * num4}\nCxD: {num3 * num4}");
        }
    }
}
