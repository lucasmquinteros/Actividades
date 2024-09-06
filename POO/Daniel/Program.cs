/*
 * Contexto:
 * Daniel es un ingeniero de transporte que esta desarrollando un sistema para gestionar diferentes tipos de vehiculos de transporte.
Quiere un programa que registre informacion sobre estos vehiculos y muestre como cada uno se desplaza 
Enunciado:
    El programa debe permitirle a daniel ingresar datos como el nombre del vehiculo y su tipo. Ademas, el programa debe ser capaz de mostrar como cada vehiculo se desplaza.
    
*/

class Transporte
{
    public string Nombre { get; set; }

    public Transporte(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void Desplazarse()
    {
        Console.WriteLine("El vehiculo se esta desplazando...");
    }
    public void MostrarInfo()
    {
        Console.WriteLine($"Vehiculo: {Nombre}");
        Desplazarse();
    }
}

class Auto : Transporte
{
    public Auto(string nombre) : base(nombre) { }

    public override void Desplazarse()
    {
        Console.WriteLine("El coche se desplaza por la autopista");
    }
}

class Bici : Transporte
{
    public Bici(string nombre) : base(nombre) { }

    public override void Desplazarse()
    {
        Console.WriteLine("La bici se desplaza por la bicicenda");
    }
}

class Avion : Transporte
{
    public Avion(string nombre) : base(nombre) { }

    public override void Desplazarse()
    {
        Console.WriteLine("El avion se desplaza por el aire");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el nombre del auto: ");
        Transporte auto = new Auto(Console.ReadLine());
        auto.MostrarInfo();

        Console.Write("Ingrese el nombre de la bici: ");
        Transporte bicicleta = new Bici(Console.ReadLine());
        Bici.MostrarInfo();

        Console.Write("Ingrese el nombre de el avion: ");
        Transporte Avionsito = new Avion(Console.ReadLine());
        Bici.MostrarInfo();

    }
}
