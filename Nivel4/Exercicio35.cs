using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio35
    {
        static void Main35(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i%10 == 0)
                {
                    Console.WriteLine($"O número {i} é múltiplo de 10\n");
                }
            }
        }
    }
}
