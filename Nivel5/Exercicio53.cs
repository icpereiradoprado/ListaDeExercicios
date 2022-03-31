using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio53
    {
        static void Main(string[] args)
        {
            uint tamanhoVetor;
            double melhorTempo = 0.0;
            int melhorVolta = 0;
            double somaTempoVoltas = 0.0; 
            double mediaVoltas;
            
            Console.WriteLine("Digite a quantidade de voltas da corrida: ");
            tamanhoVetor = Convert.ToUInt32(Console.ReadLine());
            double[] tempoVoltas = new double[tamanhoVetor];
            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.WriteLine("Digite o tempo da " + (i + 1) + "º volta");
                tempoVoltas[i] = Convert.ToDouble(Console.ReadLine());
                somaTempoVoltas += tempoVoltas[i];
                if(i == 0)
                {
                    melhorTempo = tempoVoltas[i];
                }

                if(tempoVoltas[i] < melhorTempo)
                {
                    melhorTempo = tempoVoltas[i];
                    melhorVolta = i;
                }
            }
            mediaVoltas = somaTempoVoltas / tamanhoVetor;
            mediaVoltas = Math.Round(mediaVoltas, 2);
            Console.WriteLine($"O melhor de tempo foi {melhorTempo} na volta "+(melhorVolta + 1)+$".\nO tempo médio das voltas é: {mediaVoltas}");
        }
    }
}
