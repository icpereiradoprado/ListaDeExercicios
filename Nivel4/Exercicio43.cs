using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    internal class Exercicio43
    {
        static void Main43(string[] args)
        {
            ulong totalGraos = 1;
            ulong graos = 1;
            for(int i = 2; i <= 64; i++)
            {
                graos*= 2;
                totalGraos += graos;
            }
            Console.WriteLine($"O número de grãos que o monge esperava receber era {totalGraos}");
        }
    }
}
