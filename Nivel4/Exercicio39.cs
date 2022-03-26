using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio39
    {
        static void Main39(string[] args)
        {
            int numero;
            string opcao;
            do
            {
                Console.WriteLine("Digite um número inteiro: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"O número {numero} é par");
                }
                else
                {
                    Console.WriteLine($"O número {numero} é impar");
                }
                if (numero > 0)
                {
                    Console.WriteLine($"O número {numero} é positivo");
                }
                else
                {
                    Console.WriteLine($"O número {numero} é negativo");
                }

                Console.WriteLine("\n\nDeseja continuar a execução do programa?\n\t[S ou s] - Sim\n\t[N ou n] - Não");
                opcao = Console.ReadLine();

            } while (opcao.Equals("S") || opcao.Equals("s"));


        }
    }
}
