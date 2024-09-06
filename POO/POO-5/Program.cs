public abstract class Empleado
{
    public string Nombre { get; set; }
    public double Salario { get; set; }

    public abstract double CalcularSalario();
    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }
}

public class EmpleadoTiempoCompleto : Empleado
{
    public EmpleadoTiempoCompleto(string nombre, double salario) : base(nombre, salario) { }
    public override double CalcularSalario()
    {
        return Salario;
    }
}

public class EmpleadoMedioTiempo : Empleado
{
    public EmpleadoMedioTiempo(string nombre, int salario) : base(nombre, salario) { }

    public override double CalcularSalario()
    {
        return Salario / 2;
    }
}

class Program
{
    
    static void Main()
    {
        var empleadoTiempoCompleto = new EmpleadoTiempoCompleto("Pepito", 200);
        Console.WriteLine($"El empleado {empleadoTiempoCompleto.Nombre} cobra: {empleadoTiempoCompleto.CalcularSalario()}");
        var empleadoMedioTiempo = new EmpleadoMedioTiempo("Pepita", 500);
        Console.WriteLine($"El empleado {empleadoTiempoCompleto.Nombre} cobra: {empleadoMedioTiempo.CalcularSalario()}");

    }
}