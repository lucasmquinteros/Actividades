namespace SegundaActividad.Modulos
{
    public class Pedido
    {
        public List<ArregloFloral>ArreglosFlorares { get; private set; } = new List<ArregloFloral>();
        public double Total { 
            get {
                double total = 0;
                foreach(var ArregloFloral in ArreglosFlorares)
                {
                    total += ArregloFloral.ObtenerCostoArreglo();
                }
                return total;
            } 
        }
        public bool DescuentoAplicado {
            get {
            if(ArreglosFlorares.Count > 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
        }
        public Pedido(ArregloFloral arregloFlorares)
        {
            ArreglosFlorares.Add(arregloFlorares);
        }
        public Pedido(List<ArregloFloral> arreglosFlorares)
        {
            ArreglosFlorares = arreglosFlorares;
        }
        public void AgregarArreglo(ArregloFloral arreglo)
        {
            ArreglosFlorares.Add(arreglo);
        }
    }
}
