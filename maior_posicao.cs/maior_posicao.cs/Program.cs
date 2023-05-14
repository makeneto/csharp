using System;

namespace maior_posicao.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maior = 0, posicao = 0;
            int n;

            Console.Write("Quanto numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (vet[i] > maior) {
                    maior = vet[i];
                    posicao = i;
                }
            }
            Console.WriteLine("Maior Valor = " + maior);
            Console.WriteLine("POSICAO DO MAIOR VALOR = " + posicao);
        }
    }
}