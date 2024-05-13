namespace Tenis
{
    internal class Partida
    {
        public Partida(Jogador primeiroPlayer, Jogador segundoPlayer    )
        {
            PrimeiroPlayer = primeiroPlayer;
            SegundoPlayer = segundoPlayer;
        }

        public Jogador PrimeiroPlayer { get; set; }
        public Jogador SegundoPlayer { get; set; }
    }
}