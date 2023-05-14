using System;
using System.Globalization;
namespace pagamento.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.CurrentCulture;
            string nome;
            int  hora_trab;
            double hora_inicial, pagamento;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Valor por hora: ");
            hora_inicial = double.Parse(Console.ReadLine());
            Console.Write("Horas Trabalhadas: ");
            hora_trab = int.Parse(Console.ReadLine());

            pagamento = hora_inicial * hora_trab;

            Console.WriteLine("O pagamento para "+nome+ " deve ser "+pagamento.ToString("F2"));

        }
    }
}