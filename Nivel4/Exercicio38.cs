using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio38
    {
        static void Main38(string[] args)
        {
            int codigo;
            double horasTrabalhadas;
            double horasExcedentes;
            double salarioTotal;
            double salarioExcedente;
            string opcao;
            do
            {
                Console.WriteLine("\nDigite o Código do funcionário: ");
                codigo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de Horas trabalhadas pelo funcionário: ");
                horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
                if(horasTrabalhadas > 50.00)
                {
                    horasExcedentes = horasTrabalhadas - 50.00;
                }
                else
                {
                    horasExcedentes = 0;
                }
                salarioTotal = (horasTrabalhadas * 10.00) + (horasExcedentes * 20.00);
                salarioExcedente = horasExcedentes * 20;
                Console.WriteLine($"O salário do funcionário {codigo} é: R$ {salarioTotal} e seu salário Excedente é: R$ {salarioExcedente}." +
                $"\nHoras trabalhadas {horasTrabalhadas}\nHoras excedentes {horasExcedentes}");
                Console.WriteLine("\n\nDeseja continuar a execução do programa?\n\t[S ou s] - Sim\n\t[N ou n] - Não");
                opcao = Console.ReadLine();

            } while (opcao.Equals("S") || opcao.Equals("s"));
            

        }
    }
}
