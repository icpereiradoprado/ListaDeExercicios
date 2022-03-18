using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    internal class Exercicio23
    {
        static void Main23(string[] args)
        {
            double numero1, numero2;
            int opcao;
            
            Console.WriteLine("Digite o 1º número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o 2º número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha uma das opções abaixo:\n\t[1] - Adição\n\t[2] - Subtração\n\t[3] - Multiplicação\n\t[4] - Divisão");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"\nAdição...\n{numero1} + {numero2} = {numero1 + numero2}");
                    break;
                case 2:
                    Console.WriteLine($"\nSubtração...\n{numero1} - {numero2} = {numero1 - numero2}");
                    break;
                case 3:
                    Console.WriteLine($"\nMultiplicação...\n{numero1} x {numero2} = {numero1 * numero2}");
                    break;
                case 4:
                    Console.WriteLine($"\nDivisão...\n{numero1} / {numero2} = {numero1 / numero2}");
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
