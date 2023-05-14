using System.Globalization;

namespace idade.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.Write("Digite a primeira nota: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 < 12)
            {
                Console.Write("Bom dia");
            }
            else if(n1 < 18)
            {
                Console.Write("Boa Tarde");
            }
            else
            {
                Console.Write("Boa Noite");
            }
           

        }
    }
}