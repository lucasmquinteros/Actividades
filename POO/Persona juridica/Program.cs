/*La empresa de telecomunicaciones "conexion total" necesita un sistema para gestionar los planes de internet que ofrece a sus clientes.
 * Los planes se dividen en diferentes categorias, como residencial, empresarial y movil.
 * Es fundamental que la información sobre los planes, como el nombre del plan, la velocidad de conexion y el precio mensual, este protegida y accesible solo de manera controlada.
 * Ademas, el sistema debe garantizar que el nombre del plan, la velocidad de conexion y el precio mensual sean validos.
 * 
 * Cada plan tiene que tener la posibilidad de mostrar los detalles correspondientes al mismo.
 * 
 */

class Plan
{
    private string _nombrePlan = null!;
    private int _velocidad;
    private decimal _precioMensual;

    public Plan(string nombrePlan, int velocidad, decimal precioMensual) 
    {
        NombrePlan = nombrePlan;
        Velocidad = velocidad;
        PrecioMensual = precioMensual;
    }
    public string NombrePlan 
    { 
        get { return _nombrePlan; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _nombrePlan = value;
            }
            else
            {
                Console.WriteLine("El nombre del plan no puede estar vacio");
            }
        }
    }

    public int Velocidad
    {
        get { return _velocidad;}
        set {         
        }
    }

    public decimal PrecioMensual
    {
        get { return _precioMensual; }    set { _precioMensual = value; }
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Plan de Internet\nPlan: {_nombrePlan}\nVelocidad: {_velocidad} Mbps, Precio: {_precioMensual:C}");
    }
}

class PlanResidencial : Plan
{
    public PlanResidencial(string nombre, int velocidad, decimal precioMensual) : base(nombre, velocidad, precioMensual) { }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Plan Residencial\nPlan: {NombrePlan}\nVelocidad: {Velocidad} Mbps\nPrecio: {PrecioMensual:C}");
    }
}

class PlanEmpresarial : Plan
{
    public PlanEmpresarial(string nombre, int velocidad, decimal precioMensual) : base(nombre, velocidad, precioMensual) { }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Plan Empresarial\nPlan: {NombrePlan}\nVelocidad: {Velocidad} Mbps\nPrecio: {PrecioMensual:C}");
    }
}
class PlanMovil : Plan
{
    public PlanMovil(string nombre, int velocidad, decimal precioMensual) : base(nombre, velocidad, precioMensual) { }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Plan Movil\nPlan: {NombrePlan}\nVelocidad: {Velocidad} Mbps\nPrecio: {PrecioMensual:C}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el tipo de plan que desea crear: ");
        Console.WriteLine("1 - Plan Residencial");
        Console.WriteLine("2 - Plan Empresarial");
        Console.WriteLine("3 - Plan Movil\n");

        Console.Write("Ingrese el número correspondiente al tipo de plan: ");
        int tipoPlan;
        int.TryParse(Console.ReadLine(), out tipoPlan);

        Console.Write("Ingrese el nombre del plan: ");
        string nombrePlan =  Console.ReadLine();

        Console.Write("Ingrese la velocidad del plan (Mbps): ");
        int velocidad;
        int.TryParse(Console.ReadLine(), out velocidad);

        Console.Write("Ingrese el precio mensual del plan: ");
        decimal precioMensual;
        decimal.TryParse(Console.ReadLine(), out precioMensual);

        Plan planInternet;

        switch(tipoPlan)
        {
            case 1:
                planInternet = new PlanResidencial(nombrePlan, velocidad, precioMensual);
                break;
            case 2:
                planInternet = new PlanEmpresarial(nombrePlan, velocidad, precioMensual);
                break;
            case 3:
                planInternet = new PlanMovil(nombrePlan, velocidad, precioMensual);
                break;
            default:
                Console.WriteLine("Opción no valida. Creando plan residencial por defecto");
                planInternet = new PlanResidencial(nombrePlan, velocidad, precioMensual);
                break;

        }
        planInternet.MostrarDetalles();

    }
}

