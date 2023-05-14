using System;
using System.Globalization;

namespace programa.cs
{
    class program
    {
        static void Main(string[] args)
        {
            CultureInfo MK = CultureInfo.InvariantCulture;
            int n;
            double soma = 0, media, valores = 0;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("VALORES: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vet[i] +" ");
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                soma = soma + vet[i];
            }
            Console.WriteLine("SOMA: "+soma.ToString("F2", MK));

            media = soma / n;
            Console.WriteLine("MEDIA = " +media.ToString("F2", MK));
        }
    }
}

