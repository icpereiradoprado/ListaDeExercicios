using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    internal class Exercicio22
    {
        static void Main22(string[] args)
        {
            double numero,a,b;

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if(numero >= 0)
            {
                a = numero;
                Console.WriteLine($"Número positivo armazenado em A: {a}");
            }
            else
            {
                b = numero;
                Console.WriteLine($"Número negativo armazenado em B: {b}");
            }
            
        }
    }
}
