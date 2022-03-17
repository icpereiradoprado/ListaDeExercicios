using System;

namespace Nivel2
{
    class Exercicio11
    {
        static void Main11(string[] args)
        {
            int a, b, guardarA;

            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());
            guardarA = a;
            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            a = b;
            b = guardarA;

            Console.WriteLine($"A = {a}\nB = {b}");

        }
    }
}
