using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio48
    {
        static void Main48(string[] args)
        {
            uint[] idade = new uint[20];
            string[] nome = new string[20];
            List<string> candidatasAptas = new List<string>();
            
            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine("Digite o nome da candita:");
                nome[i] = Console.ReadLine();
                Console.WriteLine($"Digite a idade da candita {nome[i]}:");
                idade[i] = Convert.ToUInt32(Console.ReadLine());
                if (idade[i] >= 18 && idade[i] <= 20)
                {
                    candidatasAptas.Add(nome[i]);
                }
            }

            foreach(var x in candidatasAptas)
            {
                Console.WriteLine($"Candidata Aptas: {x}");
            }
            
        }
    }
}
