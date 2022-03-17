using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio17
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Digite um número inteiro: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= 0 && num1 <= 9)
            {
                Console.WriteLine("Valor válido.");
            }
            else 
            {
                Console.WriteLine("Valor inválido.");
            }
        }
    }
}
