using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    internal class Exercicio8
    {
        static void Main8(string[] args)
        {
            double raio, altura, volume;

            Console.Write("Digite o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a alutra: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = (3.14159 * (raio * raio) * altura);

            Console.WriteLine($"O volume é {volume}");
        }
    }
}
