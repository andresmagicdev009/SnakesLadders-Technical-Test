using SnakesLadders.Core;
using Xunit;

namespace SnakesLadders.Tests;

// Dado falso para controlar el resultado en tests usando la interfaz IDie
public class FakeDie : IDie
{
    private readonly int _fixedValue;
    public FakeDie(int fixedValue) => _fixedValue = fixedValue;
    public int Roll() => _fixedValue;
}

public class DiceRollTests
{
    // UAT1 - El resultado siempre está entre 1 y 6
    [Fact]
    public void Die_Roll_ReturnsValueBetweenOneAndSix()
    {
        var die = new Die();

        for (int i = 0; i < 100; i++)
        {
            int result = die.Roll();
            Assert.InRange(result, 1, 6);
        }
    }

    // UAT2 - Si el dado cae en 4, el token avanza 4 casillas
    [Fact]
    public void Token_MovesFourSpaces_WhenDieRollsAFour()
    {
        var board = new Board();
        var token = new Token();
        IDie die = new FakeDie(4);

        int roll = die.Roll();
        board.Move(token, roll);

        Assert.Equal(5, token.Position);
    }
}