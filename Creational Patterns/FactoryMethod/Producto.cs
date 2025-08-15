namespace Producto {
    public interface Transporte {
        public void Deliver();
    }

    public class Camion : Transporte
    {
        public void Deliver()
        {
            Console.WriteLine("Transportando en Camion");
        }
    }

    public class Barco : Transporte
    {
        public void Deliver()
        {
            Console.WriteLine("Transportando en Barco");
        }
    }
}