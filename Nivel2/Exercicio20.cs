using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio20
    {
        static void Main(string[] args)
        {
            int a, b, c,maior,menor;
            do
            {
                Console.WriteLine("Digite um valor inteiro e maior que zero para A: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0) {
                    Console.WriteLine("Valor inválido!!\nDigite Novamente...");
                }
            } while (a < 0);

            do
            {
                Console.WriteLine("Digite um valor inteiro e maior que zero para B: ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b < 0)
                {
                    Console.WriteLine("Valor inválido!!\nDigite Novamente...");
                }
            } while (b < 0);

            do
            {
                Console.WriteLine("Digite um valor inteiro e maior que zero para B: ");
                c = Convert.ToInt32(Console.ReadLine());
                if (c < 0)
                {
                    Console.WriteLine("Valor inválido!!\nDigite Novamente...");
                }
            } while (c < 0);

            if (a > b && b > c && a > c)
            {
                maior = a;
                menor = c;
            }
            else if (a > b && b < c)
            {
                maior = a;
                menor = b;
            }
            else if (b > c && a > c)
            {
                maior = b;
                menor = c;
            }
            else if (b > c && a < c)
            {
                maior = b;
                menor = c;
            }
            else if (c > b && a > b)
            {
                maior = c;
                menor = b;
            }
            else
            {
                maior = c;
                menor = a;
            }

            Console.WriteLine($"{menor} * {maior} = {menor * maior}\n{maior} / {menor} = {maior/menor}");
        }
    }
}
