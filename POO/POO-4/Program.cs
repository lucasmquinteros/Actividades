public abstract class Empleado
{
    public string Nombre { get; set; }
    public int Salario { get; set; }

    public Empleado (string nombre, int salario)
    {
        Nombre = nombre;
        Salario = salario;
    }
    public abstract int CalcularSalario(int Salario)
    {
        return Salario;
    }
}