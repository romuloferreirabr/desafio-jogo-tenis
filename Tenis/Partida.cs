namespace Tenis
{
    internal class Partida(Jogador primeiroPlayer, Jogador segundoPlayer)
    {
        public Jogador PrimeiroPlayer { get; init; } = primeiroPlayer;
        public Jogador SegundoPlayer { get; init; } = segundoPlayer;

        public void ImprimirPlacar()
        {
            Console.WriteLine("Placar de Tênis:");
            Console.WriteLine($"Jogador 1: {PrimeiroPlayer.Sets} sets, {PrimeiroPlayer.Games} games, {PrimeiroPlayer.Pontos} pontos no game atual");
            Console.WriteLine($"Jogador 2: {SegundoPlayer.Sets} sets, {SegundoPlayer.Games} games, {SegundoPlayer.Pontos} pontos no game atual");
            Console.WriteLine($"Próximo saque: {PrimeiroPlayer}");
        }

        public int AdicionarPonto(Jogador jogador)
        {
            jogador.Pontos++;
            if (jogador.Pontos == 4)
            {
                jogador.Pontos = 0;
                jogador.Games++;

                if (jogador.Games == 6)
                    AdicionarSet(jogador);
            }
            return jogador.Pontos;
        }

        public void AdicionarSet(Jogador jogador)
        {
            if(jogador.Sets + 1 == 4)
            {
                Console.WriteLine($"O jogador {jogador} venceu a partida!");
                Environment.Exit(0);
            }
            else
            {
                jogador.Sets++;
                jogador.Games = 0;
                jogador.Pontos = 0;
            }
        }
    }
}