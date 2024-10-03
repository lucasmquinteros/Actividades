namespace SegundaActividad.Modulos
{
    public class Flor
    {
        public string Tipo { get; private set; }
        public double Costo { get; private set; }
        public Flor(string tipo, double costo)
        {
            Tipo = tipo;
            Costo = costo;
        }
    }
}
