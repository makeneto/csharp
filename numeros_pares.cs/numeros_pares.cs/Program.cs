namespace numeros_pares.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, numeros_pares = 0;
            Console.Write("Quantos numeros você vai digitar? ");
            n = int.Parse(Console.ReadLine());


            int[] vet = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("NUMEROS PARES:");

            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    numeros_pares++;
                    Console.Write(vet[i] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE PARES = "+numeros_pares);
        }
    }
}