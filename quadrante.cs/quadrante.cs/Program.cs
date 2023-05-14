namespace quadrante.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Digite os valores das coordenadas X e Y: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            do
            {
      
                Console.Write("QUADRANTE ");

                if (x > 0 && y > 0)
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

                Console.WriteLine("Digite os valores das coordenadas X e Y: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

            } while (x != 0);
        }
    }
}