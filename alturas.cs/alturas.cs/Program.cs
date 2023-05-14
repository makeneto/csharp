using System;
using System.Globalization;

namespace alturas.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo MK = CultureInfo.InvariantCulture;
            int n, porcentual_menores, menor = 0;
            double altura_media, soma = 0;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];

            for (int i = 0; i < n; i++)
            {
              
                    Console.WriteLine("Dados da "+  +"a Pessoa:");
                    Console.Write("Nome: ");
                    nome[i] = Console.ReadLine();

                    Console.Write("Idade: ");
                    idade[i] = int.Parse(Console.ReadLine());

                    Console.Write("Altura: ");
                altura[i] = double.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i < n; i++)
            {
                soma = soma + altura[i];
            }

            altura_media = soma / n;
            Console.WriteLine("Altura média: " + altura_media.ToString("F2", MK));

            for (int i = 0; i < n; i++)
            {
                if (idade[i] < 16)
                {
                    menor++;
                }
            }

            porcentual_menores = (menor / n) * 100;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentual_menores.ToString("F2", MK));

            for (int i = 0; i < n; i++)
            {
                if (idade[i] < 16)
                {
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}