using System;
using System.Globalization;

namespace glicose.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double glicose;

            Console.Write("Digite a medida da glicose: ");
            glicose = double.Parse(Console.ReadLine());

            Console.Write("Classificação: ");

            if (glicose <= 100)
            {
                Console.Write("Normal.");
            }
            else if (glicose <= 140)
            {
                Console.Write("Elevada.");
            }
            else
            {
                Console.Write("Diabetes.");
            }
        }
    }
}