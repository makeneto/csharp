namespace duracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  segd, hora, duracao, minuto, segundos;

            Console.Write("Digite a duracao em segundos: ");
            segd = int.Parse(Console.ReadLine());

            hora = segd / 3600;
            duracao = segd % 3600;

            minuto = duracao / 60;
            segundos = duracao % 60;

            Console.WriteLine(hora + ":" + minuto + ":" + segundos);
        }
    }
}