/*Contexto:
 * Sofia es una jardinera apacionada que tiene una gran variedad de plantas en su jardin.
 * Ella quiere un programa que le permita registrar informacion sobre cada planta y mostrar como cada planta florece en diferentes estaciones del año.
 * Ella, de momento, solo tiene arboles y flores en su jardin.

    Enunciado:
        Sofia necesita registrar informacion sobre las plantas de su jardin a travez de su programa. Este programa debe permitirle ingresar datos: Nombre de la planta y su tipo.
        Ademas, el programa debe ser capaz de mostrar como cada planta florece en diferentes estaciones. Utiliza polimorfismo para manejar las diferentes formas en que las plantas florecen.

 */

class Planta
{
    public string Nombre { get; set; }

    

    public Planta(string nombre) { 
        Nombre = nombre;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Planta: {Nombre}");
    }
    public virtual void Florece()
    {
        Console.WriteLine("La planta florece");
    }

}


class Arbol : Planta
{
    public Arbol(string nombre) : base(nombre) { }

    public override void Florece()
    {
        MostrarInfo();
        Console.WriteLine("Los arboles florecen en verano y en primavera");
    }
}

class Flor : Planta
{
    public Flor(string nombre) : base(nombre) { }

    public override void Florece()
    {
        MostrarInfo();
        Console.WriteLine("Las flores florecen en primavera y otoño");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el Nombre de la planta: ");
        string Nombre = Console.ReadLine();

        
        Planta arbolito = new Arbol(Nombre);

        arbolito.Florece();
    }
}