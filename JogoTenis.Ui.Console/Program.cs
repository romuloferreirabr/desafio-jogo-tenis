using JogoTenis.Domain.Models;
using System;

public class Program
{
    public static void Main()
    {
        var placar = new Placar();
        int opcao;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Iniciar/Reiniciar partida");
            Console.WriteLine("2 - Marcar ponto para o Jogador 1");
            Console.WriteLine("3 - Marcar ponto para o Jogador 2");
            Console.WriteLine("4 - Ver placar");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    placar.ReiniciarPartida();
                    Console.WriteLine("\nPartida iniciada...\n");
                    break;
                case 2:
                    placar.MarcarPontoParaJogador1();
                    Console.WriteLine("\nPonto marcado para o Jogador 1.\n");
                    break;
                case 3:
                    placar.MarcarPontoParaJogador2();
                    Console.WriteLine("\nPonto marcado para o Jogador 2.\n");
                    break;
                case 4:
                    Console.WriteLine("\n" + placar.ObterPlacar() + "\n");
                    break;
                case 0:
                    Console.WriteLine("\nSaindo...\n");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.\n");
                    break;
            }
        } while (opcao != 0);
    }
}
