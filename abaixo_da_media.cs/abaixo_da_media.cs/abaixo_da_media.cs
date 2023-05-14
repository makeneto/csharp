using System.Globalization;

namespace abaixo_da_media.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo MK = CultureInfo.InvariantCulture;
            int N;
            double media, soma = 0;

            Console.Write("Quantos elementos vai ter o vetor? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), MK);
                soma = soma + vet[i];
            }

            media = soma / N;
            Console.WriteLine("MEDIA DO VETOR = " + media.ToString("F3", MK));

            Console.WriteLine("ELEMENTOS A BAIXO DA MEDIA:");
            for (int i = 0; i < N; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1"));
                }
            }
        }
    }
}