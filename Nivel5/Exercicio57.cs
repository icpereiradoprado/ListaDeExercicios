using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio57
    {
        static void Main57(string[] args)
        {
            string frase;
            string newFrase = "";

            Console.WriteLine("Digite uma frase:");
            frase = Console.ReadLine();


            foreach (var vogal in frase)
            {
                if (vogal == 'A' || vogal == 'a')
                {
                    newFrase += 'a';
                }
                if (vogal == 'E' || vogal == 'e')
                {
                    newFrase += 'e';
                }
                if (vogal == 'I' || vogal == 'i')
                {
                    newFrase += 'i';
                }
                if (vogal == 'O' || vogal == 'o')
                {
                    newFrase += 'o';
                }
                if (vogal == 'U' || vogal == 'u')
                {
                    newFrase += 'u';
                }
            }

            Console.WriteLine($"Frase digitada com apenas as vogais:\n{newFrase}");


        }
    }
}
