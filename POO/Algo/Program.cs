class Vehiculo
{
    public string Marca { get; set; }

    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    protected void MostrarDetalles()
    {
        Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo}");
    }
}

class Auto : Vehiculo
{
    public int NumeroDePuertas { get; set; }

    public Auto(string marca, string modelo, int numeroDePuertas) : base(marca, modelo)
    {
        NumeroDePuertas = numeroDePuertas;
    }

    public void MostrarInfoAuto()
    {
        MostrarDetalles(); //Para usar el metodo protegido
        Console.WriteLine($"Numero de puertas: {NumeroDePuertas}");
    }
}

class Program
{
    static void Main()
    {
        Auto auto = new Auto("Renault", "Sandero", 4);

        auto.MostrarInfoAuto();
    }
}