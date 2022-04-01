using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio55
    {
        static void Main55(string[] args)
        {
            string fraseUsuario;
            string newfraseUsuario;
            int contador = 0;
            int contadorLetras = 0;
            Console.WriteLine("Digite uma frase de até 50 caracteres: ");
            fraseUsuario = Console.ReadLine();

            foreach (var letra in fraseUsuario)
            {
                contadorLetras = fraseUsuario.IndexOf(' ');

                if (letra.Equals(' '))
                {
                    contador++;
                }
            }
            Console.WriteLine($"Quantidade de espaços em branco encontrado na frase => {contador}");
            newfraseUsuario = String.Concat(fraseUsuario.Where(c => !Char.IsWhiteSpace(c)));
            Console.WriteLine($"Frase sem espaços em branco:\n{newfraseUsuario}");
        }
    }
}
