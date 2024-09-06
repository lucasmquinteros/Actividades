class Persona
{
    private string _nombre;
    private int _edad;

    public string Nombre 
    { 
        get { return _nombre;  }
        set { _nombre = value; }
    }
    public int Edad
    { 
        get { return _edad;  }
        set { _edad = value; }
    }
}

class Program
{
    static void Main()
    {
        Persona persona = new Persona
        {
            Nombre = "Juanito",
            Edad = 14
        };
        
        Console.WriteLine($"Nombre: {persona.Nombre}");
        Console.WriteLine($"Edad: {persona.Edad}");
    }
}