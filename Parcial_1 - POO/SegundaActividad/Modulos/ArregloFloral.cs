namespace SegundaActividad.Modulos
{
    public class ArregloFloral
    {
        public List<Flor>Flores { get; private set; } = new List<Flor>();
        public ArregloFloral(Flor flor)
        {
            Flores.Add(flor);
        }
        public ArregloFloral(List<Flor> flores)
        {
            Flores.AddRange(flores);
        }
        public double ObtenerCostoArreglo()
        {
            double costoTotal = 0;
            foreach(var Flor in Flores)
            {
                costoTotal += Flor.Costo;
            }
            return costoTotal;
        }
        public void AgregarFlor(Flor flor)
        {
            Flores.Add(flor);
        }
    }
}
