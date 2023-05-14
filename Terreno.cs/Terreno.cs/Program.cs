using System;
using System.Globalization;
namespace Terreno.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, comprimento, metro_quadrado, area, preco;

            Console.Write("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do metro quadrado: ");
            metro_quadrado = double.Parse(Console.ReadLine());

            area = largura * comprimento;
            preco = area * metro_quadrado;

            Console.WriteLine("Area = " + area.ToString("F2", CI));
            Console.WriteLine("Preco = " + preco.ToString("F2", CI));


        }
    }
}