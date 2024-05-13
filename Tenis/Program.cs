namespace Tenis
{
    internal class Program
    {
        public static Partida partida = new Partida(new Jogador(), new Jogador());

        static void Main(string[] args)
        {
            partida.ImprimirPlacar();

            var resultado = Console.ReadLine();

            if(resultado == "1")
                partida.AdicionarPonto(partida.PrimeiroPlayer);
            else if(resultado == "2")
                partida.AdicionarPonto(partida.SegundoPlayer);
            
            Main(args);
        }
    }
}
