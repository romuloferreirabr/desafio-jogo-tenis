using Xunit;
using JogoTenis.Domain.Models;

public class TestesJogoTenis
{
    /// <summary>
    /// Teste para verificar se um jogador ganha um ponto corretamente. 
    /// </summary>
    [Fact]
    public void TestarMarcarPonto()
    {
        var jogador1 = new Jogador();
        var jogador2 = new Jogador();
        jogador1.MarcarPonto(jogador2);
        jogador1.MarcarPonto(jogador2);
        Assert.Equal(2, jogador1.Pontos);
        Assert.Equal(30, jogador1.Pontuacao);
    }

    /// <summary>
    /// Teste para verificar se um jogador ganha um game corretamente.
    /// </summary>
    [Fact]
    public void TestarMarcarGame()
    {
        var jogador1 = new Jogador();
        var jogador2 = new Jogador();
        for (int i = 0; i < 4; i++)
        {
            jogador1.MarcarPonto(jogador2);
        }
        Assert.Equal(1, jogador1.Games);
    }

    /// <summary>
    /// Teste para verificar se um jogador ganha um set corretamente.
    /// </summary>
    [Fact]
    public void TestarMarcarSet()
    {
        var jogador1 = new Jogador();
        var jogador2 = new Jogador();
        for (int i = 0; i < 6; i++)
        {
            jogador1.MarcarGame(jogador2);
        }
        Assert.Equal(1, jogador1.Sets);
    }

    /// <summary>
    /// Teste para verificar se o tie-break é iniciado corretamente quando os jogos estão empatados em 6-6.
    /// </summary>
    [Fact]
    public void TestarIniciarTieBreak()
    {
        var jogador1 = new Jogador();
        var jogador2 = new Jogador();
        for (int i = 0; i < 6; i++)
        {
            jogador1.MarcarGame(jogador2);
            jogador2.MarcarGame(jogador1);
        }
        Assert.True(jogador1.IsTieBreak);
        Assert.True(jogador2.IsTieBreak);
    }

    /// <summary>
    /// Teste para verificar se um jogador ganha o tie-break corretamente.
    /// </summary>
    [Fact]
    public void TestarMarcarPontoTieBreak()
    {
        var jogador1 = new Jogador();
        var jogador2 = new Jogador();
        for (int i = 0; i < 7; i++)
        {
            jogador1.MarcarPontoTieBreak(jogador2);
        }
        Assert.Equal(1, jogador1.Sets);
        Assert.False(jogador1.IsTieBreak);
        Assert.False(jogador2.IsTieBreak);
    }

    /// <summary>
    /// Teste para verificar se um jogador é marcado como vencedor corretamente.
    /// </summary>
    [Fact]
    public void TestarVencedor()
    {
        var jogador1 = new Jogador();
        for (int i = 0; i < 3; i++)
        {
            jogador1.MarcarSet();
        }
        Assert.True(jogador1.Vencedor);
    }

}
