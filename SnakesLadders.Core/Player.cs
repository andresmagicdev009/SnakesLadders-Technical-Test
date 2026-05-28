namespace SnakesLadders.Core;

/// <summary>
/// Representa a un jugador en el juego Serpientes y Escaleras, con un nombre y una ficha (Token).
/// </summary>
public class Player
{
    public string Name { get; }
    public Token Token { get; }

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="Player"/>.
    /// </summary>
    /// <param name="name">El nombre del jugador.</param>
    public Player(string name)
    {
        Name = name;
        Token = new Token();
    }
}