using Parcial.Interfaz;

namespace Parcial.Modulos
{
    public class Gimnasio : Imostrable
    {
        public List<Clase> Clases { get; private set; } = new List<Clase>();
        public string Nombre { get; private set; }
        public Gimnasio(string nombre)
        {
            Nombre = nombre;
        }
        public Gimnasio(string nombre, List<Clase> clases)
        {
            Clases.AddRange(clases);
            Nombre = nombre;
        }
        public void AgregarClase(Clase clase)
        {
            Clases.Add(clase);
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Gimnasio: {Nombre}");
            foreach(var clase in Clases)
            {
                clase.MostrarDetalles();
                Console.WriteLine();
            }
        }
    }
}
