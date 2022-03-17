using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio16
    {
        static void Main16(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite o 1º número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 2º número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"O 1º número ({num1}) é maior que o 2º número ({num2}).");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"O 2º número ({num2}) é maior que o 1º número ({num1}).");
            }
            else 
            {
                Console.WriteLine($"Os números são iguais\n{num1} = {num2}.");
            }
        }
    }
}
