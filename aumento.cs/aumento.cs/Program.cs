using System;
using System.Globalization;

namespace aumento.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double salario, novo_salario, aumento;
            int porcentagem;

            Console.Write("Digite o salario da pessoa: ");
            salario = double.Parse(Console.ReadLine());

            if (salario <= 1000)
            {
                porcentagem = 20;
            }
            else if (salario <= 3000)
            {
                porcentagem = 15;
            }
            else if (salario <= 8000)
            {
                porcentagem = 10;
            }
            else
            {
                porcentagem = 5;
            }

            aumento = salario * porcentagem;
            novo_salario = aumento + salario;

            Console.WriteLine("NOVO SALARIO = " + novo_salario.ToString("F2", CI));
            Console.WriteLine("AUMENTO = " + aumento);
            Console.WriteLine("PORCENTAGEM = " + porcentagem +"%");

            
        }
    }
}