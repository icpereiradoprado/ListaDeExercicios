using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    internal class Exercicio10
    {
        static void Main(string[] args) 
        {
            int numero1, numero2;
            bool igual, naoIgual, maior, menor, maiorIgual, menorIgual;

            Console.WriteLine("Digite o 1º número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2º número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            igual = numero1 == numero2;
            naoIgual = numero1 != numero2;
            maior = numero1 > numero2;
            menor = numero1 < numero2;
            maiorIgual = numero1 >= numero2;
            menorIgual = numero1 <= numero2;

            Console.WriteLine($"O 1º número é igual ao 2º número: {igual}\nO 1º número é diferente do 2º número: {naoIgual}\nO 1º número é maior do que o 2º número: {maior}\nO 1º número é menor do que o 2º número: {menor}\nO 1º número é maior ou igual ao 2º número: {maiorIgual}\nO 1º número é menor ou igual ao 2º número: {menorIgual}");
        }
    }
}
