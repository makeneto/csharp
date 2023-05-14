using System;
using System.Globalization;

namespace Menor_de_tres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first, second, third, menore = 0;

            Console.Write("Primeiro valor: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Primeiro valor: ");
            second = int.Parse(Console.ReadLine());

            Console.Write("Primeiro valor: ");
            third = int.Parse(Console.ReadLine());

            if (first < second && first < third)
            {
                menore = first;
            }
            else if (second < first && second < third)
            {
                menore = second;
            }
            else
            {
                menore = third;
            }

            Console.Write("MENOR = " + menore);
        }
    }
}