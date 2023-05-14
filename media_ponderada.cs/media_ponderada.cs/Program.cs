using System;
using System.Globalization;

namespace media_ponderada.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int n;
            double a, b, c, media, soma = 0; 

            Console.Write("Quantos casos voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite tres numeros: ");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());

                media = (a + b + c) / 3;
                Console.WriteLine("MEDIA = " + media.ToString("F1", CI));
            }
        }
    }
}