using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio30
    {
        static void Main30(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número para o cálculo da Tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
