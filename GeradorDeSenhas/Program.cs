using System;
using System.Text;

namespace GeradorDeSenhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE A QUANTIDADE DE CARACTERES DESEJADA : ");

            if (int.TryParse(Console.ReadLine(), out int qtd) && qtd > 0)
            {
                string caracteresPossiveis = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789%$#@!";

                Random sorteio = new Random();

                int numeroSorteado = 0;

                StringBuilder senha = new StringBuilder();

                for (int i = 0; i < qtd; i++)
                {
                    numeroSorteado = sorteio.Next(0, caracteresPossiveis.Length - 1);
                    senha.Append(caracteresPossiveis[numeroSorteado]);
                }

                Console.WriteLine(senha);
                Console.WriteLine("Pressione qualquer tecla para sair.");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Por favor, insira um valor válido para a quantidade de caracteres.");
            }
        }
    }
}
