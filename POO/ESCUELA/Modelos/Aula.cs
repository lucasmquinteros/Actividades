
using ESCUELA.Modelos.Interfaces;

namespace ESCUELA.Modelos
{
    public class Aula : EntidadConNombre, IListaEditable<Estudiante>
    {

        public Profesor profesor { get; set; }

        private List<Estudiante> _estudiantes = new List<Estudiante>();
        public List<Estudiante> Estudiantes { get { return _estudiantes; } }

        public Aula(string nombre, Profesor profesor) : base(nombre)
        {

            this.profesor = profesor;

        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            profesor.MostrarDetalles();
            Console.WriteLine($"Estudiantes:\n");
            foreach (var Alumno in Estudiantes)
            {
                Alumno.MostrarDetalles();
            }
        }

        public void Añadir(Estudiante entity)
        {
            _estudiantes.Add(entity);
        }

        public void Quitar(Estudiante entity)
        {
            _estudiantes.Remove(entity);
        }
    }
}
