using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio37
    {
        static void Main37(string[] args)
        {
            int operacao;
            int num1 = 0;
            int num2 = 0;
            string opcao;
            do
            {
                Console.WriteLine("\nEscolha uma opção abaixo:\n\t[1] - Adição\n\t[2] - Subtração\n\t[3] - Multiplicação\n\t[4] - Divisão");
                operacao = Convert.ToInt32(Console.ReadLine());
                if(operacao <= 0 || operacao > 4)
                {
                    Console.WriteLine("O valor inserido para a opação é inválido!!");
                }
                else
                {
                    Console.WriteLine("Digite o 1º número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o 2º número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                switch (operacao)
                {
                    case 1:
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
                        break;
                    case 4:
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        break;
                }
                Console.WriteLine("Deseja continuar?\n\t[S ou s] - Sim\n\t[N] - Não");
                opcao = Console.ReadLine();
            } while (opcao.Equals("S") || opcao.Equals("s"));
            

        }
    }
}
