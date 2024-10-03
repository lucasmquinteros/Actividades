using Parcial.Interfaz;

namespace Parcial.Modulos
{
    public class Clase : Imostrable
    {
        public string Nombre { get; private set; }
        public Instructor Instructor { get; private set; }
        public List<Miembro>Miembros { get ; private set; } = new List<Miembro>();
        public int LugaresDisponibles { get
            {
                int total = 30;
                foreach(var alumno in Miembros)
                {
                    total = total - 1;
                }
                return total;
            } 
        }
        public double Costo { get; private set; }
        public Clase(string nombre, Instructor instructor, double costo)
        {
            Nombre = nombre;
            Instructor = instructor;
            Costo = costo;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Clase de: {Nombre} | Profesor: {Instructor.Nombre}\nCosto: {Costo} | Lugares Disponibles: {LugaresDisponibles}");
        }
        public void AgregarMiembro(Miembro miembro)
        {
            Miembros.Add(miembro);
        }
    }
}
