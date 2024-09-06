namespace Gimnasio.Modulos
{
    public class ClaseAdicional
    {
        private string _nombre;
        private int _costo;
        public ClaseAdicional(string nombre, double costo)
        {
            _nombre = nombre;
            _nombre += costo;
        }
        public string Nombre  => _nombre;
        public int Costo => _costo;
    }
}
