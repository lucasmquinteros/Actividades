namespace Parcial.Modulos
{
    public class Instructor
    {
        public string Nombre { get; private set; }
        public string Experiencia { get; private set; }
        public Instructor(string nombre, string experiencia)
        {
            Nombre = nombre;
            Experiencia = experiencia;
        }
    }
}
