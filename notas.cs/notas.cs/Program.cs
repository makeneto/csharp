using System;
using System.Globalization;
namespace notas.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double n1, n2, media;

            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            media = n1 + n2;

            Console.WriteLine("NOTA FINAL = " + media.ToString("f1", CI));

            if (media < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }

        }
    }
}
