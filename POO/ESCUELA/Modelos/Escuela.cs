using ESCUELA.Modelos;
using ESCUELA.Modelos.Interfaces;


namespace ESCUELA.Modelos
{
    public class Escuela : EntidadConNombre, IListaEditable<Aula>
    {

        public Administrador Administrador { get; set; }

        private List<Aula> _aulas = new List<Aula>();

        public List<Aula> Aulas { get { return _aulas; } }

        public Escuela(string nombre, Administrador administrador) : base(nombre)
        {
            this.Administrador = administrador;
        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Aulas:\n");
            Administrador.MostrarDetalles();
            foreach (var Aula in _aulas)
            {
                Aula.MostrarDetalles();
            }
        }

        public void Añadir(Aula entity)
        {
            _aulas.Add(entity);
        }

        public void Quitar(Aula entity)
        {
            _aulas.Remove(entity);
        }

        
    }
}
