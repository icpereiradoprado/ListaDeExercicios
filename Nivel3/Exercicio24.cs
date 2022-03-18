using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    internal class Exercicio24
    {
        static void Main24(string[] args)
        {
            int num1, num2,opcao;

            Console.WriteLine("Digito um valor inteiro para o 1º número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digito um valor inteiro para o 2º número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha uma das opções abaixo:\n\t[1] - Múltiplos\n\t[2] - Pares\n\t[3] - Média\n\t[4] - Sair");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"\nVerificando se os números digitados são múltiplos...");
                    if (num1 % num2 == 0)
                    {
                        Console.WriteLine($"\n{num1} é múltiplo de {num2}");
                    }
                    else
                    {
                        Console.WriteLine($"\n{num1} NÂO é múltiplo de {num2}");
                    }
                    break;
                case 2:
                    Console.WriteLine($"\nVerificando se os números digitados são pares...");
                    if (num1%2 == 0 && num2%2 == 0)
                    {
                        Console.WriteLine($"Os números {num1} e {num2} são pares.");
                    }
                    else
                    {
                        Console.WriteLine($"Os números NÂO são pares.");
                    }
                    break;
                case 3:
                    Console.WriteLine($"\nVerificando se a média dos números digitados é maior ou igual a 7...");
                    if((num1+num2) / 2 >= 7)
                    {
                        Console.WriteLine($"A média {(num1 + num2) / 2} é maior ou igual a 7");
                    }
                    else
                    {
                        Console.WriteLine($"A média {(num1 + num2) / 2} é menor do que 7");
                    }
                    break;
                case 4:
                    Console.WriteLine($"\nSaindo...");
                    break;
                default:
                    Console.WriteLine("\nValor inválido");
                    break;
            }
            Console.WriteLine("\n\nPressione qualquer tecla para fechar o programa!");
            Console.ReadKey();
        }
    }
}
