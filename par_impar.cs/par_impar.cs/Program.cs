namespace par_impar.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("NULO.");
                }
                else
                {
                    if (x % 2 == 0)
                    {
                        Console.Write("PAR ");
                    }
                    else
                    {
                        Console.Write("IMPAR ");
                    }
                    if (x < 0)
                    {
                        Console.WriteLine("NEGATIVO.");
                    }
                    else
                    {
                        Console.WriteLine("POSITIVO.");
                    }
                }                  
            }
        }
    }
}