namespace SpawnerSystem {
    public class SpawnerMontaña : Spawner {
        public Enemigos.iMelee.IMelee CrearEnemigoMelee() {
            return new Enemigos.iMelee.CabraMontaña();
        }

        public Enemigos.iRange.IRange CrearEnemigoDistancia() {
            return new Enemigos.iRange.EsqueletoMontaña();
        }
    }
}