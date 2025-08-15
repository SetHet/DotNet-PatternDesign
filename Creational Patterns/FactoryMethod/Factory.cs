namespace Factory {
    public abstract class Logisticas {
        public void PlanDelivery() {
            // ejecutar logica
        }

        public abstract Producto.Transporte CreateLogistica();
    }

    public class RoadLogistica : Logisticas
    {
        public override Producto.Transporte CreateLogistica()
        {
            return new Producto.Camion();
        }
    }

    public class SeaLogistica : Logisticas 
    {
        public override Producto.Transporte CreateLogistica()
        {
            return new Producto.Barco();
        }
    }
}