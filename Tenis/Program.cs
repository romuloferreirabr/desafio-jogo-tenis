namespace Tenis
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Placar de Tênis:");
            Console.WriteLine("Jogador 1: 0 sets, 5 games, 40 pontos no game atual");
            Console.WriteLine("Jogador 2: 0 sets, 5 games, 40 pontos no game atual");
            Console.WriteLine("Próximo saque: Jogador 1");

            var resultado = Console.ReadLine();
            Main(args);
        }
    }
}
