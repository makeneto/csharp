namespace combustivel.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, alcool = 0, gasolina = 0, diesel = 0;

            do
            {
               Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 1)
                {
                    alcool++;
                }
                else if (codigo == 2)
                {
                    gasolina++;
                }
                else if (codigo == 3)
                {
                    diesel++;
                }
            } while (codigo != 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("AlCOOL: " + alcool);
            Console.WriteLine("GASOLINA: " + gasolina);
            Console.WriteLine("DIESEL: " + diesel);
        }
    }
}