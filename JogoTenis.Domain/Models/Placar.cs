namespace JogoTenis.Domain.Models;

public class Placar
{
    public Jogador Jogador1 { get; set; }
    public Jogador Jogador2 { get; set; }

    public Placar()
    {
        Jogador1 = new Jogador();
        Jogador2 = new Jogador();
    }

    public void MarcarPontoParaJogador1()
    {
        if (Jogador1.Vencedor)
            Console.WriteLine("Jogador 1 ganhou a partida!");
        else if (Jogador1.IsTieBreak || Jogador2.IsTieBreak)
            Jogador1.MarcarPontoTieBreak(Jogador2);
        else
            Jogador1.MarcarPonto(Jogador2);
    }

    public void MarcarPontoParaJogador2()
    {
        if (Jogador2.Vencedor)
            Console.WriteLine("Jogador 2 ganhou a partida!");
        if (Jogador1.IsTieBreak || Jogador2.IsTieBreak)
            Jogador2.MarcarPontoTieBreak(Jogador1);
        else
            Jogador2.MarcarPonto(Jogador1);
    }

    public void ReiniciarPartida()
    {
        Jogador1 = new Jogador();
        Jogador2 = new Jogador();
    }

    public string ObterPlacar()
    {
        if (Jogador1.IsTieBreak || Jogador2.IsTieBreak)
        {
            return $"Jogador 1: {Jogador1.Sets} sets, {Jogador1.Games} games, {Jogador1.PontosTieBreak} pontos no tie-break\n" +
                   $"Jogador 2: {Jogador2.Sets} sets, {Jogador2.Games} games, {Jogador2.PontosTieBreak} pontos no tie-break";
        }
        else
        {
            return $"Jogador 1: {Jogador1.Sets} sets, {Jogador1.Games} games, {Jogador1.Pontuacao} pontos no game atual\n" +
                   $"Jogador 2: {Jogador2.Sets} sets, {Jogador2.Games} games, {Jogador2.Pontuacao} pontos no game atual";
        }
    }

}
