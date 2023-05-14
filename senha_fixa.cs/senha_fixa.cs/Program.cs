namespace senha_fixa.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  senha;

            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Senha Invalida! Tente novamente: ");
                senha = int.Parse(Console.ReadLine());

            } while (senha != 2005);

            Console.WriteLine("ACESSO PERMITIDO");
        }
    }
}