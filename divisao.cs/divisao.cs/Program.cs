using System;
using System.Globalization;

namespace divisao.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo MK = CultureInfo.InvariantCulture;
            int n, numerador, denominador;
            double divisao;

            Console.Write("Quantos casos voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Entre com o numerador: ");
                numerador = int.Parse(Console.ReadLine());
                Console.Write("Entre com o numerador: ");
                denominador = int.Parse(Console.ReadLine());

                if (numerador < 0 )
                {
                    Console.WriteLine("DIVISAO IMPOSSÍVEL");
                }
                else
                {
                    divisao = numerador / denominador;
                    Console.WriteLine("DIVISAO = " + divisao.ToString("F2", MK));
                }
            }
        }
    }
}