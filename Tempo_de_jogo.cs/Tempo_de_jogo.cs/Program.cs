namespace Tempo_de_jogo.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora_inicial, hora_final, duracao;
            Console.Write("Hora inicial: ");
            hora_inicial = int.Parse(Console.ReadLine());

            Console.Write("Hora final: ");
            hora_final = int.Parse(Console.ReadLine());

            if (hora_inicial < hora_final )
            {
                duracao = hora_final - hora_inicial;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
                
            }
            else
            {
                duracao = 24 - (hora_inicial + hora_final);
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            
        }
    }
}