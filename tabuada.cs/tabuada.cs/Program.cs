namespace tabuada.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, resultado;
            Console.Write("Deseja a tabuada para qual valor? ");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i < 12; i++)
            {
                resultado = x * i;
                Console.WriteLine(x + " x " + i + " = " + resultado);
            }
            
        }
    }
}