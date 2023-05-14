using System;
using System.Globalization;
namespace troco.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco, dinheiro_recebido, troco;
            int qtd;
            Console.Write("Preço unitário do produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            qtd = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            dinheiro_recebido = double.Parse(Console.ReadLine());

            troco = dinheiro_recebido - (preco * qtd);

            Console.Write("TROCO = " + troco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}