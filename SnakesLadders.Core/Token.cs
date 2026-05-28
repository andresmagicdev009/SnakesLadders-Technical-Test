namespace SnakesLadders.Core;

/// <summary>
/// Representa la ficha de un jugador en el tablero.
/// </summary>
public class Token
{
    /// <summary>
    /// Posición actual de la ficha. Inicia en la casilla 1.
    /// </summary>
    public int Position { get; private set; } = 1;

    /// <summary>
    /// Mueve la ficha a la posición indicada.
    /// </summary>
    /// <param name="position">Casilla destino.</param>
    public void MoveTo(int position)
    {
        Position = position;
    }
}
