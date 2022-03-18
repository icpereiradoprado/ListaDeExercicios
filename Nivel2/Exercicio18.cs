using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio18
    {
        static void Main18(string[] args) 
        {
            int codigo;

            Console.WriteLine("Digite o código: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            if(codigo > 0 && codigo <= 3)
            {
                Console.WriteLine($"Códgio Válido!!");

                switch (codigo) {
                    case 1:
                        Console.WriteLine("Um");
                        break;
                    case 2:
                        Console.WriteLine("Dois");
                        break;
                    case 3:
                        Console.WriteLine("Três");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Códgio inválido!!");
            }
        }
    }
}
