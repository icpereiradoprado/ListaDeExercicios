using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    internal class Exercicio5
    {
        static void Main(string[] args)
        {
            double tempoViagem, distanciaPercorrida, litrosUsados;
            int velocidadeMedia;

            Console.WriteLine("Digite o tempo gasto na viagem: ");
            tempoViagem = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média: ");
            velocidadeMedia = Convert.ToInt32(Console.ReadLine());

            distanciaPercorrida = tempoViagem * Convert.ToDouble(velocidadeMedia);

            litrosUsados = distanciaPercorrida / 12.00;

            Console.WriteLine("A quantidade gasta de combustível é: "+litrosUsados.ToString());
        }
    }
}
