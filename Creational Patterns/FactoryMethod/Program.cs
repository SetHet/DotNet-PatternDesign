using Factory;

Console.WriteLine("============= Start =============");
Console.WriteLine("Factory Method");
Console.WriteLine("Description: \nFactory Method es un patrón de diseño creacional que proporciona una interfaz para crear objetos en una superclase, mientras permite a las subclases alterar el tipo de objetos que se crearán.");
Console.WriteLine("https://refactoring.guru/es/design-patterns/factory-method");
Console.WriteLine("============= Execute =============");


// Entrada de datos del usuario
Console.WriteLine("Elegir logistica");
Console.WriteLine(
    "1. Terrestre\n"+
    "2. Maritimo"
);
int minEntrada = 1;
int maxEntrada = 2;
string? entrada = Console.ReadLine();

if (entrada == null) throw new Exception("No se ingreso un numero");
int entradaInt = int.Parse(entrada);
if (!(entradaInt >= minEntrada && entradaInt <= maxEntrada)) throw new Exception("No se ingreso un numero entre 1 y 2");


// Crear la fabrica
Logisticas logistica;

switch (entradaInt) {
    case 1:
        logistica = new RoadLogistica();
        break;
    case 2:
        logistica = new SeaLogistica();
        break;
    default:
        Console.WriteLine("No se encontro la logistica");
        return;
}

// Crear un producto
Producto.Transporte transporte = logistica.CreateLogistica();

// Usar un producto
transporte.Deliver();

