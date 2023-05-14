using System;
using System.Globalization;

namespace media_pares.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo MK = CultureInfo.InvariantCulture;
            int N, cout = 0, soma = 0;
            double media;

            Console.Write("Quantos elementos vai ter o vetor? ");
            N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());

                if (vet[i] % 2 == 0)
                {
                    soma = soma + vet[i];
                    cout++;
                }
            }

            if (cout == 0)
            {
                Console.Write("NENHUM NUMERO PAR");
            }
            else
            {
                media = soma / cout;
                Console.Write("MEDIA DOS PARES: " + media.ToString("F1", MK));
            }
        }
    }
}