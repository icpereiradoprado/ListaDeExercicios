using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio54
    {

        static void Main54(string[] args)
        {
            int contador = 0;
            int[] vetorA = new int[5];
            int[] vetorB = new int[8];
            int[] vetorC = new int[8];
            bool existe;


            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro para a " + (i + 1) + "º posição do vetor A");
                vetorA[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(""); //Console para pular uma linha entre os For's

            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro para a " + (i + 1) + "º posição do vetor B");
                vetorB[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(var a in vetorA)
            {
                foreach(var b in vetorB)
                {

                    existe = false;
                    foreach (var c in vetorC)
                    {
                        if(c == b)
                        {
                            existe = true;
                        }

                    }

                    if (b == a && !existe)
                    {
                        vetorC[contador] = b;
                        contador++;
                    }
                }
            }
            
            foreach(var c in vetorC)
            {
                if (c > 0)
                {
                    Console.WriteLine($"Os valores indênticos entre os vetores A e B são: {c}");
                }
            }

            
        }
    }

}
