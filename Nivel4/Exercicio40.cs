using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    internal class Exercicio40
    {
        static void Main40(string[] args)
        {
            string opcao;
            double indicePoluicao;
            do
            {
                Console.WriteLine("Digite o índice de poluição medido: ");
                indicePoluicao = Convert.ToDouble(Console.ReadLine()); ;
                if(indicePoluicao == 0.3 || indicePoluicao < 0.4)
                {
                    Console.WriteLine("Alerta !!\nO índice de poluição está acima do aceitável." +
                        "\nIndustriás pertencentes ao 1º grupo devem suspender suas atividades!" +
                        $"\n\tÍndice aceitável [0,05 à 0,25]\n\tÍndice medidio {indicePoluicao}");
                }
                else if(indicePoluicao == 0.4 || indicePoluicao < 0.5)
                {
                    Console.WriteLine("Alerta !!\nO índice de poluição está acima do aceitável." +
                        "\nIndustriás pertencentes ao 1º e 2º grupo devem suspender suas atividades!" +
                        $"\n\tÍndice aceitável [0,05 à 0,25]\n\tÍndice medidio {indicePoluicao}");
                }
                else if(indicePoluicao >= 0.5)
                {
                    Console.WriteLine("Alerta !!\nO índice de poluição está acima do aceitável." +
                        "\nIndustriás pertencentes ao 1º, 2º e 3º grupo devem suspender suas atividades!"
                        +$"\n\tÍndice aceitável [0,05 à 0,25]\n\tÍndice medidio {indicePoluicao}");
                }
                else
                {
                    Console.WriteLine("O índice de poluição está dentro do aceitável");
                }
                Console.WriteLine("\n\nDeseja continuar a execução do programa?\n\t[S ou s] - Sim\n\t[N ou n] - Não");
                opcao = Console.ReadLine();
            } while (opcao.Equals("S") || opcao.Equals("s"));
        }
    }
}
