using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio14
    {
        static void Main14(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite o 1º número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o 2º número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine($"A diferença do 1º número para o 2º número é {num1 - num2}");
            }
            else 
            {
                Console.WriteLine($"A diferença do 2º número para o 1º número é {num2 - num1}");
            }
        }
    }
}
