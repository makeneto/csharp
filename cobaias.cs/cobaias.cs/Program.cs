using System;
using System.Globalization;

namespace cobaias.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo MK = CultureInfo.InvariantCulture;
            int n, Quantidade_de_cobaias, soma = 0, coelho = 0, sapo = 0, rato = 0;
            char Tipo_de_cobaia;
            double porcoelho, porrato, porsapo;

            Console.Write("Quantos casos de teste serao digitados?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Quantidade de cobaias: ");
                Quantidade_de_cobaias = int.Parse(Console.ReadLine());
                soma = soma + Quantidade_de_cobaias;

                Console.Write("Tipo de cobaia: ");
                Tipo_de_cobaia = char.Parse(Console.ReadLine());
                

                if (Tipo_de_cobaia == 'C')
                {
                    coelho = coelho + Quantidade_de_cobaias;
                }

                else if (Tipo_de_cobaia == 'S')
                {
                    sapo = sapo + Quantidade_de_cobaias;
                }

                else if (Tipo_de_cobaia == 'R')
                {
                    rato = rato + Quantidade_de_cobaias;
                }

            }

                porcoelho = ((double)coelho / soma) * 100.0;
                porrato = ((double)rato / soma) * 100.0;
                porsapo = ((double)sapo / soma) * 100.0;

            Console.WriteLine();
                Console.WriteLine("Total: " + soma + " cobaias.");
                Console.WriteLine("Total de coelhos: " +coelho);
                Console.WriteLine("Total de ratos: " +rato);
                Console.WriteLine("Total de sapos: " +sapo);
                Console.WriteLine("Porcentagem de coelhos: " +porcoelho.ToString("F2", MK));
                Console.WriteLine("Porcenagem de ratos: " +porrato.ToString("F2", MK));
                Console.WriteLine("Porcentagem de sapos: " +porsapo.ToString("F2", MK));
        }
    }
}