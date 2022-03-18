using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    internal class Exercicio25
    {
        static void Main(string[] args)
        {
            double altura;
            int sexo;

            Console.WriteLine("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu sexo\n\t[1] - Masculino\n\t[2] - Feminino");
            sexo = Convert.ToInt32(Console.ReadLine());

            if(sexo == 1)
            {
                Console.WriteLine($"Seu peso ideal é {(72.7 * altura) - 58}");
            }
            else
            {
                Console.WriteLine($"Seu peso ideal é {(62.1 * altura) - 44.7}");
            }

            Console.WriteLine("\n\nPressione qualquer tecla para fechar o programa!");
            Console.ReadKey();
        }
    }
}
