namespace Tenis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var primeiroJogador = new Jogador { Nome = "Primeiro Jogador" };
            var segundoJogador = new Jogador { Nome = "Segundo Jogador" };
            var partida = new Partida(primeiroJogador, segundoJogador);

            while (true)
            {
                partida.Imprimir();
                var resultado = Console.ReadLine();

                if (resultado == "1")
                    partida.Pontuar(partida.PrimeiroPlayer);
                else if (resultado == "2")
                    partida.Pontuar(partida.SegundoPlayer);
                else if (resultado == "3")
                    partida.AdicionarSet(partida.PrimeiroPlayer);
                else if (resultado == "4")
                    partida.AdicionarSet(partida.SegundoPlayer);
            }
        }
    }
}
