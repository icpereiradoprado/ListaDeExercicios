using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio36
    {
        static void Main36(string[] args)
        {
            int numero;
            int soma=0;
            double media;
            int cont = 0;
            int maior = 0;
            int menor = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite um número inteiro positivo: ");
                numero = Convert.ToInt32(Console.ReadLine());
                soma += numero;
                cont++;
                if(cont == 1)
                {
                    menor = numero;
                    maior = numero;
                }
                if(numero < 0)
                {
                    i--;
                }
                else if(numero > maior)
                {
                    maior = numero;
                }
                else if(numero < menor)
                {
                    menor = numero;
                }

            }
            media = soma / 10.00;
            Console.WriteLine($"O maior número é {maior}.\nO menor número é {menor}.\nA média dos números digitado é {media}");
            
        }
    }
}
