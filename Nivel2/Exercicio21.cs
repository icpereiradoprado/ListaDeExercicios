using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    internal class Exercicio21
    {
        static void Main21(string[] args)
        {
            int numero,opcao;
            do
            {
                Console.WriteLine("Escolha uma opção abaixo:\n\t[1] - Executar programa\n\t[2] - Parar Execução");
                opcao = Convert.ToInt32(Console.ReadLine());
                if(opcao != 1) 
                {
                    break;
                }
                Console.WriteLine("\n\nDigite um número inteiro: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero >= 0)
                {
                    Console.WriteLine("Número Positivo.\n");
                }
                else
                {
                    Console.WriteLine("Número Negativo.\n");
                }
            } while (opcao == 1);   
        }
    }
}
