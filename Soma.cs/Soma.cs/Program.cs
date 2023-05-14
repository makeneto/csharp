namespace Soma.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma = 0;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            soma = x + y;

            Console.Write("SOMA = " + soma);
        }
    }
}