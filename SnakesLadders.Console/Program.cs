using SnakesLadders.Core;


Console.WriteLine("\n");
Console.WriteLine("Snakes and Ladders GAME ! by Andres :D\n");
Console.Write("Hola jugador, ¿cuál es tu nombre? ");
string name = Console.ReadLine() ?? "Jugador Anonimo";



var player = new Player(name);
var game = new Game(player, new Die());

Console.WriteLine($"\n¡Bienvenido {player.Name}! Puedes comenzar el juego presionando ENTER.");
Console.WriteLine("Escribe 'salir' para terminar el juego en cualquier momento.\n");
Console.WriteLine($"Inicias en la posicion {game.Position}!\n");


/// <summary>
/// Si el juego no ha terminado, se espera a que el usuario presione ENTER para lanzar el dado y avanzar en el tablero hasta llegar a la casilla 100 o escribir "salir" para terminar el juego.
/// </summary>
while (!game.IsOver)
{
    // Lee la entrada del usuario. Si el usuario escribe "salir", se termina el juego. De lo contrario, se lanza el dado y se mueve la ficha.
    string? input = Console.ReadLine();

    // Si el usuario escribe "salir", se muestra un mensaje de despedida y se rompe el ciclo para terminar el programa.
    if (input?.ToLower() == "salir")
    {
        Console.WriteLine("Juego terminado.");
        break;
    }
    
    // Si el usuario presiona ENTER (input es null o vacío), se lanza el dado y se mueve la ficha. Se muestra el resultado del dado, la nueva posición y si el jugador ha ganado.
    int prevPosition = game.Position;
    // Llama al método PlayTurn() del juego, que lanza el dado, mueve la ficha y retorna una tupla con el resultado del dado, la nueva posición y si el jugador ha ganado.
    var (roll, position, hasWon) = game.PlayTurn();

    Console.WriteLine($"Tu dado ha obtneido un numero {roll}");
    Console.WriteLine($"Tu posicion ahora es {position}\n");

    if (hasWon)
        Console.WriteLine("¡Ganaste! Llegaste a la casilla 100.");
    else if (position == prevPosition)
        Console.WriteLine("Te pasaste, quedas en tu posición actual.");
}
