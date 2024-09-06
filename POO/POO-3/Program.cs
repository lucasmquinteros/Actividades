public abstract class DispositivoElectronico
{
    public string Marca { get; set; }
    public abstract void Encender();

    public DispositivoElectronico(string marca)
    {
        Marca = marca;
    }
}


class Radio : DispositivoElectronico
{
    public Radio(string marca) : base(marca) { }

    public override void Encender()
    {
        Console.WriteLine($"Encendio su radio {Marca}");
    }
}

class Televisor : DispositivoElectronico
{
    public Televisor(string marca) : base(marca) { }

    public override void Encender()
    {
        Console.WriteLine($"Encendio su televisor {Marca}");
    }
}

class Program
{
    static void Main()
    {
        DispositivoElectronico radio = new Radio("Philco");
        radio.Encender();   
        Dis
    }
}
//empleado, tiempo completo, medio tiempo y van a tener en comun el nombre y salario como atributo, metodo CALCULARSALARIO