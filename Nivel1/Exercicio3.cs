using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio3
    {
        static void Main3(string[] args)
        {
            string nome, codigoPeca;
            double precoPeca, pagamentoComissao;
            int qtdVendida;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o código da peça: ");
            codigoPeca = Console.ReadLine();

            Console.WriteLine("Digite o preço unitário da peça: ");
            precoPeca = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de peças vendidas: ");
            qtdVendida = Convert.ToInt32(Console.ReadLine());

            pagamentoComissao = (precoPeca * qtdVendida)* 0.05;
            Console.WriteLine("Comissão do vendedor: R$ "+String.Format("{0:0.00}",pagamentoComissao)+" Referente ao valor total da venda: "+String.Format("{0:0.00}",precoPeca * qtdVendida));

        }
    }
}
