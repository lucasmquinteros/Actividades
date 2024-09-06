
namespace ESCUELA.Modelos
{
    public class Proyecto : EntidadConNombre
    {
        public string Descripcion { get; set; }

        public Proyecto(string nombre, string descripcion) : base(nombre)
        {
            Descripcion = descripcion;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Descripcion: {Descripcion}");
        }
        public void EvaluarProyecto(Evaluador evualuador)
        {
            Console.WriteLine($"{Nombre} está siendo evaluado por {evualuador.Nombre} ...");
        }
    }
}
