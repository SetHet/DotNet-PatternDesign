namespace SpawnerSystem {
    public class SpawnerPantano : Spawner {
        public Enemigos.iMelee.IMelee CrearEnemigoMelee() {
            return new Enemigos.iMelee.ZombiePantano();
        }

        public Enemigos.iRange.IRange CrearEnemigoDistancia() {
            return new Enemigos.iRange.EsqueletoPantano();
        }
    }
}