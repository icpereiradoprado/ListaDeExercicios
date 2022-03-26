using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    internal class Exercicio44
    {
        static void Main44(string[] args)
        {
            string continuar;
            int opcao;
            do
            {
                Console.WriteLine("Escolha uma das opcões abaixo:\n\t[1] - Conversão de Graus Celsius em Graus Fahrenheit.\n\t[2] - Conversão de Graus Fahrenheit em Graus Celsius.\n\t[3] - Peso ideal do homem\n\t[4] - Peso ideal da mulher");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao <= 0 || opcao > 4)
                {
                    Console.WriteLine("O valor inserido para a opção é inválido!!");
                }
                else
                {
                    switch (opcao)
                    {
                        case 1:
                            string C;
                            int F;

                            Console.WriteLine("Digite a temperatura em ºC");
                            C = Console.ReadLine();
                            F = ((9 * Convert.ToInt32(C)) + 160) / 5;

                            Console.WriteLine($"{C}ºC em Fahrenheit é {F}ºF");
                            break;
                        case 2:
                            string fahrenheit;
                            int celsius;

                            Console.WriteLine("Digite a temperatura em ºF");
                            fahrenheit = Console.ReadLine();

                            celsius = (Convert.ToInt32(fahrenheit) - 32) * 5 / 9;

                            Console.WriteLine($"{fahrenheit}ºF em Celsius é {celsius}ºC");
                            break;
                        case 3:
                            double alturaHomem;
                            double pesoIdealHomem;
                            double pesoHomem;

                            Console.WriteLine("Digite sua altura: ");
                            alturaHomem = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite seu peso atual: ");
                            pesoHomem = Convert.ToDouble(Console.ReadLine());

                            pesoIdealHomem = (72.7 * alturaHomem) - 58;
                            pesoIdealHomem = Math.Round(pesoIdealHomem, 2);
                            Console.WriteLine($"Seu peso ideal é "+String.Format("{0:0.00}",pesoIdealHomem));
                            if(pesoHomem > pesoIdealHomem)
                            {
                                Console.WriteLine("Você está acima do peso Ideal");
                            }
                            else if (pesoHomem < pesoIdealHomem)
                            {
                                Console.WriteLine("Você está abaixo do peso Ideal");
                            }
                            else
                            {
                                Console.WriteLine("Você está no peso Ideal");
                            }
                            break;
                        case 4:
                            double alturaMulher;
                            double pesoIdealMulher;
                            double pesoMulher;

                            Console.WriteLine("Digite sua altura: ");
                            alturaMulher = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite seu peso atual: ");
                            pesoMulher = Convert.ToDouble(Console.ReadLine());

                            pesoIdealMulher = (62.1 * alturaMulher) - 44.7;
                            pesoIdealMulher = Math.Round(pesoIdealMulher, 2);
                            Console.WriteLine($"Seu peso ideal é "+String.Format("{0:0.00}", pesoIdealMulher));
                            if (pesoMulher > pesoIdealMulher)
                            {
                                Console.WriteLine("Você está acima do peso Ideal");
                            }
                            else if (pesoMulher < pesoIdealMulher)
                            {
                                Console.WriteLine("Você está abaixo do peso Ideal");
                            }
                            else
                            {
                                Console.WriteLine("Você está no peso Ideal");
                            }
                            break;
                    }
                }
                Console.WriteLine("\n\nDeseja continuar a execução do programa?\n\t[S ou s] - Sim\n\t[N ou n] - Não");
                continuar = Console.ReadLine();
            } while (continuar.Equals("S") || continuar.Equals("s"));
        }
    }
}
