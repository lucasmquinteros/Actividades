//auto y moto

public abstract class Vehiculo 
{
    public string Marca { get; set; }
    public string Modelo { get; set; } 

    public Vehiculo(string marca, string modelo)
    {
        this.Marca =  marca;
        this.Modelo = modelo;
    }
    public abstract void Conducir();
}

class Auto : Vehiculo
{
   public Auto(string marca, string modelo) : base(marca, modelo) { }

    public override void Conducir()
    {
        Console.WriteLine($"Estas manejando un auto marca: {Marca} y modelo {Modelo}");
    }


}






class Program
{
    static void Main()
    {
        Vehiculo auto = new Auto("Toyota", "Corolla");
        auto.Conducir();
    }
}