using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    internal class Exercicio9
    {
        static void Main9(string[] args)
        {
            int idade, mes, dia;
            double idadeDias;

            Console.WriteLine("Digite sua idade em Ano, Mês e Dia.\nExemplo: 20 anos 4 meses e 10 dias.");

            Console.WriteLine("Ano: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mês: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dias: ");
            dia = Convert.ToInt32(Console.ReadLine());

            idadeDias = ((idade * 365) + (mes * 30) + dia);

            Console.WriteLine($"Sua idade em dias é: {idadeDias} dias");

        }
    }
}
