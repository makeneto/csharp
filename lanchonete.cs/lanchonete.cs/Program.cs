using System;
using System.Globalization;

namespace testebool.cs
{
    internal class Program
   {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            int codigo, qtd;
            double pagar;

            Console.Write("Codigo do produto comprado: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            qtd = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                pagar = 5.00 * qtd;
                Console.WriteLine("Valor a pagar = R$" + pagar.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 2)
            {
                pagar = 3.50 * qtd;
                Console.WriteLine("Valor a pagar = R$" + pagar.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 3)
            {
                pagar = 4.80 * qtd;
                Console.WriteLine("Valor a pagar = R$" + pagar.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4)
            { 
                pagar = 8.90 * qtd;
                Console.WriteLine("Valor a pagar = R$" + pagar.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 5)
            {
                pagar = 7.32 * qtd;
                Console.WriteLine("Valor a pagar = R$" +pagar.ToString("F2", CultureInfo.InvariantCulture));
            }

       }

   }

}