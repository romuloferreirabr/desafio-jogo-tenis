namespace JogoTenis.Domain.Models;

public class Jogador
{
    public int Pontos { get; set; } = 0;
    public int Pontuacao { get; set; } = 0;
    public int PontosTieBreak { get; set; } = 0;
    public int Games { get; set; } = 0;
    public int Sets { get; set; } = 0;
    public bool IsTieBreak { get; set; } = false;
    public bool Vencedor { get; set; } = false;



    public void MarcarPonto(Jogador oponente)
    {
        Pontos++;
        Pontuacao = Pontos switch
        {
            1 => 15,
            2 => 30,
            3 => 40,
            _ => 0
        };

        if (Pontos == 4)
        {
            Pontos = 0;
            Pontuacao = 0;
            MarcarGame(oponente);
        }
    }

    public void MarcarPontoTieBreak(Jogador oponente)
    {
        PontosTieBreak++;
        if (PontosTieBreak >= 7 && PontosTieBreak - oponente.PontosTieBreak >= 2)
        {
            PontosTieBreak = 0;
            oponente.PontosTieBreak = 0;
            IsTieBreak = false;
            oponente.IsTieBreak = false;
            MarcarSet();
        }
    }

    public void MarcarGame(Jogador oponente)
    {
        Games++;
        if (Games == 6 && oponente.Games == 6)
        {
            IsTieBreak = true;
            oponente.IsTieBreak = true;
        }
        else if (Games == 7 || (Games == 6 && oponente.Games < 5))
        {
            Games = 0;
            MarcarSet();
        }
    }

    public void MarcarSet()
    {
        Sets++;
        if(Sets == 3)
        {
            Sets = 0;
            Vencedor = true;
        }
    }
}
