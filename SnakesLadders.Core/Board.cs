namespace SnakesLadders.Core;

/// <summary>
/// Representa el tablero del juego Serpientes y Escaleras.
/// </summary>
public class Board
{
    /// <summary>
    /// Número total de casillas del tablero.
    /// </summary>
    public const int Size = 100;

    /// <summary>
    /// Mueve una ficha el número de espacios indicados.
    /// Retorna true si el jugador ganó (llegó exactamente a la casilla 100).
    /// Retorna false si el movimiento supera el límite del tablero.
    /// </summary>
    /// <param name="token">Ficha a mover.</param>
    /// <param name="spaces">Número de casillas a avanzar.</param>
    /// <returns>True si el jugador gana, false si el movimiento no es válido.</returns>
    public bool Move(Token token, int spaces)
    {
        int newPosition = token.Position + spaces; // 1 + 3 = 4

        if (newPosition > Size) // 4 > 100? No entonces no entra al if
        {
            return false;
        }

        token.MoveTo(newPosition); // llama a la funcion MoveTo(4)
        return newPosition == Size; //  4 == 100? No entonces retorna false
    }
}
