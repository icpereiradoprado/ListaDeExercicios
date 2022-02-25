using System;

namespace Nivel1
{
    class Exercicio1
    {
        static void Main1(string[] args)
        {
            double estoqueMedio, qtdMinima, qtdMaxima;
            
            Console.WriteLine("Digite a quantidade mínima: ");
            qtdMinima = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade máxima: ");
            qtdMaxima = Convert.ToDouble(Console.ReadLine());

            estoqueMedio = (qtdMinima + qtdMaxima) / 2;

            Console.WriteLine($"Estoque Médio: {estoqueMedio}");



        }
    }
}
