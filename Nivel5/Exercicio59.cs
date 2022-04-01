using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio59
    {
        static void Main59(string[] args)
        {
            string alfabeto = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            string letra1;
            string letra2;
            string letra1Upper;
            string letra2Upper;
            int numeroCaracters;
            string[] newAlfabeto = new string[25];
            newAlfabeto = alfabeto.Split();

            Console.WriteLine("Digite uma letra entre A-Z");
            letra1 = Console.ReadLine();
            letra1Upper = letra1.ToUpper();

            Console.WriteLine("Digite outra letra entre A-Z");
            letra2 = Console.ReadLine();
            letra2Upper = letra2.ToUpper();

            numeroCaracters = (Array.IndexOf(newAlfabeto, letra2Upper) - Array.IndexOf(newAlfabeto, letra1Upper)) - 1;
            if (numeroCaracters < 0)
            {
                Console.WriteLine("Erro!\nDigite os dois caracteres em ordem alfabética: ");
            }
            else
            {
                Console.WriteLine($"O número de caracters entre eles é: {numeroCaracters}");
            }
        }
    }
}
