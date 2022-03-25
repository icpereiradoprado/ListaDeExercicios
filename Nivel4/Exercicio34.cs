using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio34
    {
        static void Main34(string[] args)
        {
            int numeros = 0;
            int maior = 0;
            int menor = 0;
            int cont = 0;


            while (true)
            {
                Console.WriteLine("Digite um número inteiro positivo.\nCaso queira encerrar o programa, digite um número negativo;");
                numeros = Convert.ToInt32(Console.ReadLine());
                cont++;
                if(cont == 1)
                {
                    menor = numeros;
                    maior = numeros;
                }

                if (numeros < 0)
                {
                    break;
                }
                else if (numeros > maior)
                {
                    maior = numeros;
                    
                   
                }
                else if(numeros < menor)
                {
                    menor = numeros;
                }
            }
            Console.WriteLine($"O maior número digitado é {maior}.\nO menor número digitado é {menor}");
            
        }
    }
}
