using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    internal class Exercicio41
    {
        static void Main41(string[] args)
        {
            int idade;
            string opcao;
            do
            {
                Console.WriteLine("Digite a idade do nadador");
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade > 4 && idade <= 7)
                {
                    Console.WriteLine("Nadador Infantil A");
                }
                else if(idade > 7 && idade <= 11)
                {
                    Console.WriteLine("Nadador Infantil B");
                }
                else if (idade > 11 && idade <= 13)
                {
                    Console.WriteLine("Nadador Juvenil A");
                }
                else if (idade > 13 && idade <= 17)
                {
                    Console.WriteLine("Nadador Juvenil B");
                }
                else if (idade >= 18)
                {
                    Console.WriteLine("Nadador Adultos");
                }
                else
                {
                    Console.WriteLine("Idade inválida para a classificação das categorias!");
                }
                Console.WriteLine("\n\nDeseja continuar a execução do programa?\n\t[S ou s] - Sim\n\t[N ou n] - Não");
                opcao = Console.ReadLine();
            } while (opcao.Equals("S") || opcao.Equals("s"));

        }
    }
}
