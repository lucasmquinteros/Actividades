using System.Reflection.Metadata.Ecma335;

namespace ListaDeTareas.Models
{
    public class Tarea
    {
        public string Descripcion { get; private set; }
        public bool IsCompletado { get; set; }
        public Tarea(string descripcion, bool completada = false)
        {
            Descripcion = descripcion;
            IsCompletado = completada;
        }
        public override string ToString()
        {
            return $"{Descripcion} - {(IsCompletado ? "Completada" : "Pendiente")}";
        }

    }
}
