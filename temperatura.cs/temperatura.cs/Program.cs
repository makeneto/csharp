using System;
using System.Globalization;

namespace temperatura.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double temp, Celsius, Far;
            char C, F; 

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            temp = double.Parse(Console.ReadLine());

            if (temp == 'F')
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                Celsius = double.Parse(Console.ReadLine());

                Celsius = 5.0 / 9.0 * (Far - 32.0);
                Console.Write("Temperatura equivalente em Fahrenheit: " +Celsius.ToString("F2", CI));
            }
            else
            {
                Console.Write("Digite a temperatura em Celsius: ");
                Celsius = double.Parse(Console.ReadLine());
              
                Far = 9.0 / 5.0 * (Celsius - 32.0);
                Console.Write("Temperatura equivalente em Fahrenheit: " + Far.ToString("F2", CI));
            }
        }
    }
}