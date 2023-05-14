using System;
using System.Globalization;

namespace consumo.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.CurrentCulture;
            int distancia;
            double Combustivel, consumo;

            Console.Write("Distancia percorrida: ");
            distancia = int.Parse(Console.ReadLine());
            Console.Write("Combustível gasto: ");
            Combustivel = double.Parse(Console.ReadLine());

            consumo = distancia / Combustivel;

            Console.Write("Consumo medio = " + consumo.ToString("F3", CI));
        }
    }
}