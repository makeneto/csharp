using System;
using System.Globalization;

namespace media_idades.cs
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, cout = 0, soma = 0;
            double  media;

            Console.WriteLine("Digite as idades: ");
            x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");

            }
            else
            {
                while (x > 0)
                {
                    cout = cout + 1;
                    soma = soma + x;
                    x = int.Parse(Console.ReadLine());
                }

                media = soma / cout;

                Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
            }
        }
    }
}