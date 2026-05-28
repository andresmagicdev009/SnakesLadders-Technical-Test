using SnakesLadders.Core;
using Xunit;

namespace SnakesLadders.Tests;

public class TokenMovementTests
{
    private readonly Board _board = new();
    private readonly Token _token = new();

    [Fact]
    public void Token_StartsOnSquareOne_WhenGameBegins()
    {
        Assert.Equal(1, _token.Position);
    }

    [Fact]
    public void Token_MovesToSquareFour_WhenMovedThreeSpaces()
    {
        _board.Move(_token, 3);
        Assert.Equal(4, _token.Position);
    }

    [Fact]
    public void Token_MovesToSquareEight_WhenMovedThreeThenFourSpaces()
    {
        _board.Move(_token, 3);
        _board.Move(_token, 4);
        Assert.Equal(8, _token.Position);
    }

    [Fact]
    public void Token_LandsOnHundred_AndPlayerWins_WhenMovedExactly()
    {
        _token.MoveTo(97);
        bool hasWon = _board.Move(_token, 3);

        Assert.Equal(100, _token.Position);
        Assert.True(hasWon);
    }

    [Fact]
    public void Token_StaysOnSquare97_AndPlayerDoesNotWin_WhenOvershoot()
    {
        _token.MoveTo(97);
        bool hasWon = _board.Move(_token, 4);

        Assert.Equal(97, _token.Position);
        Assert.False(hasWon);
    }
}