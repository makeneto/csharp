namespace Coordenadas.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            
            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());


            if (x == 0 && y == 0)
            {
                Console.WriteLine("ORIGEM");
            }
            else if (x > 0 && y == 0)
            {
                Console.WriteLine("EIXO X");
            }
            else if (x == 0 && y > 0)
            {
                Console.WriteLine("EIXO Y");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }

        }
    }
}