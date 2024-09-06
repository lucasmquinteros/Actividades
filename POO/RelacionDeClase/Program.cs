/*En la empresa "Text solutions", cada empleado tiene una tarjeta de identificacion personal que contiene su nombre, apellido, numero de identificacion y fecha de emision.
 * La empresa necesita implementar un sistema que gestione a los empleados y sus tarjetas de identificación.

 */

class TarjetaIdentificacion
{
    static int tarjetas = 0;
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }    
    public int NumeroIdentificacion { get; private set; }
    public DateTime FechaEmision { get; private set; } = DateTime.Now;

    public TarjetaIdentificacion(string nombre, string apellido) {
        Nombre = nombre;
        Apellido = apellido;
        NumeroIdentificacion = ++tarjetas;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Tarjeta de identificacion: {Nombre} {Apellido}\nID: {NumeroIdentificacion}\nEmitida el {FechaEmision.ToShortDateString()}");
    }
}


class Empleado
{
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public TarjetaIdentificacion Tarjeta { get; private set; }

    public Empleado(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
        Tarjeta = new TarjetaIdentificacion(Nombre, Apellido);
    }

    public void MostrarDetallesEmpleado()
    {
        Tarjeta.MostrarDetalles();
    }
}

class Program
{
    static void Main()
    {
     
        Empleado empleado = new Empleado("Juan", "Perez");
        Empleado empleado2 = new Empleado("Juan", "Doe");
        empleado.MostrarDetallesEmpleado();
        empleado2.MostrarDetallesEmpleado();
    }
}