using ESCUELA.Modelos;


namespace ESCUELA.Modelos
{
    public class Materia : EntidadConNombre
    {
        private int _creditos;
        public int Creditos
        {
            get { return _creditos; }
            set
            {
                if (value >= 0)
                {
                    _creditos = value;
                }
                else
                {
                    throw new ArgumentException("La experiencia no debe ser negativa");
                }
            }
        }
        public Materia(string nombre, int creditos) : base(nombre)
        {
            Creditos = creditos;
        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.Write($"Creditos: {Creditos}\n");
        }
    }
}
