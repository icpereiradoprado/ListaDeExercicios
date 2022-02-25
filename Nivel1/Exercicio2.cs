using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio2
    {
        static void Main(string[] args) 
        {
            double cotacaoDolar, valorDolares, converteReal;

            Console.WriteLine("Digite a cotação dolar: ");
            cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantide de dolares que você deseja converter: ");
            valorDolares = Convert.ToDouble(Console.ReadLine());

            converteReal = cotacaoDolar * valorDolares;

            Console.WriteLine("O valor convertido em Reais é: R$ "+String.Format("{0:0.00}", converteReal));


        }
    }
}
