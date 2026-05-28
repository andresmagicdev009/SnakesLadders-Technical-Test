namespace SnakesLadders.Core;

/// <summary>
/// Esta clae representa un dado con resultado entre 1 y 6.
/// </summary>
public class Die : IDie
{
    private readonly Random _random = new(); // Instancia la clase Random para generar numeros aleatorios

    /// <summary>
    /// La clase Roll lanza el dado y retorna un numero aleatorio entre 1 y 6.
    /// 
    /// </summary>
    public int Roll() => _random.Next(1, 7); // Invocando la funcion Next se puede obtener numeros del 1 al 6  
}
