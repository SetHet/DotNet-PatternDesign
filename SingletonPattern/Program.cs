new Player();
var player = Player.GetPlayer();
player.nombre = "Evans";
Console.WriteLine(Player.GetPlayer().nombre);

    
// Clase que no se puede instanciar y solo tiene datos globales
public static class Puntaje {
    // Variable unica y global
    public static uint puntaje = 0;
}

// Clase instanciable que representa un jugador, que tendra una funcion que permite encontralo
public class Player {
    // variable normal
    public string nombre;
    // Variable oculta que apunta al player unico
    private static Player? _playerInstance;

    // Agregar al player en el constructor como el unico
    public Player(){
        _playerInstance = this;
        nombre = "default";
    }

    // Funcion que entrega al player
    public static Player GetPlayer(){
        // si no existe se crea un player
        if (_playerInstance == null){
            _playerInstance = new Player();
        }
        // retorna el player unico
        return _playerInstance;
    }

    
}




