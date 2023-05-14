namespace soma_vetores.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, soma = 0;
            Console.Write("Quantos valores vai ter cada vetor? ");
            n = int.Parse(Console.ReadLine());

            int[] A = new int[n], B = new int[n], C = new int[n];

            Console.WriteLine("Digite os valores do vetor A: ");
            for (int i = 0; i < n; i++)
            {                
                A[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Digite os valores do vetor B: ");
            for (int i = 0; i < n; i++)
            {              
                B[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("VALOR RESULTANTE: ");
            for (int i = 0; i < n; i++)
            {           
                C[i] = A[i] + B[i];
                Console.WriteLine(C[i]);

            }
        }
    }
}