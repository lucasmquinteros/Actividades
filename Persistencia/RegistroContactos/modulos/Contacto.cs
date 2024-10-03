namespace RegistroContactos.modulos
{
    public class Contacto
    {
        public string Nombre { get;  set; }
        public int Telefono { get;  set; }
        public string CorreoElectronico { get; set; }
        public Contacto(string nombre, int telefono, string correoElectronico)
        {
            Nombre = nombre;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
        }
    }
}
