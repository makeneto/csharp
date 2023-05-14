using System;
using System.Globalization;

namespace dardo.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double x, y, z, maior = 0;

            Console.WriteLine("Digite as tres distancias:");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine());

            if (x > y && x > z)
            {
                maior = x;
            }
            else if (y > x && y > z)
            {
                maior = y;
            }
            else
            {
                maior = z;
            }

            Console.WriteLine("MAIOR DISTANCIA = " + maior.ToString("F2", CI));
        }
    }
}