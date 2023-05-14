using System;

namespace mais_velho.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, mais_velha, posicaomaior;
     
            Console.Write("Quantas pessoas voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            int[] idade = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Dados da " + i + 1 + "a pessoa");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("PESSOA MAIS VELHA: ");
            mais_velha = idade[0];

            for (int i = 0; i < N; i++)
            {
                if (idade[i] > mais_velha)
                {
                    mais_velha = idade[i];
                    posicaomaior = i;
                }
            }
            Console.Write(nome[posicaomaior]);
        }
    }
}