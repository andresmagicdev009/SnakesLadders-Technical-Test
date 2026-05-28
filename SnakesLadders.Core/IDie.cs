namespace SnakesLadders.Core;

/// <summary>
/// Interfaz para cualquier implementación de dado.
/// Permite inyectar dados reales o falsos en tests.
/// </summary>
/// <summary>
/// Explicacion de porque esta interfaz es importante en las pruebas unitarias 
/// Al crear un dado no se puede controlar el numero que arroja ya que es aleatorio, 
/// con la interfaz podemos crear un dado fake que facilite arrojar siempre el mismo numero,
/// lo que nos permite probar el comportamiento del juego de manera predecible.
/// Ademas al implementar la interfaz IDie se sigue los principios de diseño SOLID 
/// específicamente el principio de inversión de dependencias, lo que hace que el código sea más flexible y fácil de mantener.
/// </summary>
public interface IDie
{
    /// <summary>
    /// Lanza el dado y retorna el resultado.
    /// </summary>
    /// <returns>Número obtenido en el lanzamiento.</returns>
    int Roll(); // Metodo abstracto que puede ser implementado por diferentes clases de dados, como Die o FakeDie, etc...
}
