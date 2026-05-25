using Enemigos.iMelee;
using Enemigos.iRange;
using SpawnerSystem;

Console.WriteLine("============= Start =============");
Console.WriteLine("Abstract Factory");
Console.WriteLine("Description: \nAbstract Factory es un patrón de diseño creacional que nos permite producir familias de objetos relacionados sin especificar sus clases concretas.");
Console.WriteLine("https://refactoring.guru/es/design-patterns/abstract-factory");
Console.WriteLine("============= Execute =============");

Console.WriteLine("= Modo manual =>");
Spawner spawn = new SpawnerPantano();
spawn.CrearEnemigoMelee().AtaqueCercano();
spawn.CrearEnemigoDistancia().AtaqueDistancia();

spawn = new SpawnerMontaña();
spawn.CrearEnemigoMelee().AtaqueCercano();
spawn.CrearEnemigoDistancia().AtaqueDistancia();

Console.WriteLine("= Modo listado =>");
Spawner[] spawns = new Spawner[] {new SpawnerPantano(), new SpawnerMontaña()};
foreach (Spawner s in spawns){
    s.CrearEnemigoMelee().AtaqueCercano();
    s.CrearEnemigoDistancia().AtaqueDistancia();
}