namespace SpawnerSystem {
    public interface Spawner {
        public Enemigos.iMelee.IMelee CrearEnemigoMelee();
        public Enemigos.iRange.IRange CrearEnemigoDistancia();
    }
}