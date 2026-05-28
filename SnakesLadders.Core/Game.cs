namespace SnakesLadders.Core;

/// <summary>
/// Controla el flujo principal del juego Serpientes y Escaleras.
/// Coordina el dado, el jugador y el tablero en cada turno.
/// </summary>
public class Game
{
    private readonly Board _board;
    private readonly Player _player;
    private readonly IDie _die; // Inyección de dependencia: permite usar dado real o dado falso en tests

    /// <summary>
    /// Indica si el juego terminó (el jugador llegó a la casilla 100).
    /// </summary>
    public bool IsOver { get; private set; }

    /// <summary>
    /// Posición actual de la ficha del jugador en el tablero.
    /// </summary>
    public int Position => _player.Token.Position;

    /// <summary>
    /// Crea una nueva partida con el jugador y el dado indicados.
    /// </summary>
    /// <param name="player">Jugador que participará en la partida.</param>
    /// <param name="die">Implementación del dado a usar (real o falso).</param>
    public Game(Player player, IDie die)
    {
        _board = new Board();
        _player = player;
        _die = die;
    }

    /// <summary>
    /// Ejecuta un turno: lanza el dado y mueve la ficha del jugador.
    /// Si la nueva posición supera 100, la ficha no se mueve.
    /// </summary>
    /// <returns>
    /// Tupla con el resultado del dado, la posición resultante
    /// y si el jugador ganó en este turno.
    /// </returns>
    public (int roll, int position, bool hasWon) PlayTurn()
    {
        int roll = _die.Roll();
        bool hasWon = _board.Move(_player.Token, roll);
        IsOver = hasWon;
        return (roll, _player.Token.Position, hasWon);
    }
}
