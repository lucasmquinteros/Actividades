class InstrumentoMusical
{
    public string Nombre { get; set; }
    
    public string Tipo { get; set; }

    public InstrumentoMusical(string nombre, string tipo)
    {
        Nombre = nombre;
        Tipo = tipo;
    }
    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre} \n Tipo: {Tipo}");
    }
}

class InstrumentoMusicalDeCuerda : InstrumentoMusical 
{ 
    public int NumeroCuerda { get; set; }

    public InstrumentoMusicalDeCuerda(int numeroCuerda, string nombre, string tipo) : base(nombre, tipo)
    {
        NumeroCuerda = numeroCuerda;
    }

    public void MostrarInfoCuerda()
    {
        MostrarInfo();
        Console.WriteLine($"Cantidad de cuerdas: {NumeroCuerda}");
    }
}

class InstrumentoMusicalDeViento : InstrumentoMusical
{
    public string Material { get; set; }

    public InstrumentoMusicalDeViento(string material, string nombre, string tipo) : base(nombre, tipo)
    {
        Material = material;
    }

    public void MostrarInfoViento()
    {
        MostrarInfo();
        Console.WriteLine($"Tipo de material: {Material}");
    }
}

class InstrumentoMusicalDePercusion : InstrumentoMusical
{
    public bool UsaPalillos { get; set; }
    
    public InstrumentoMusicalDePercusion(bool usaPalillos, string nombre, string tipo) : base(nombre, tipo)
    {
        UsaPalillos = usaPalillos;
    }

    public void MostrarInfoPercusion()
    {
        MostrarInfo();
        if (UsaPalillos)
        {
            Console.WriteLine("Si usa palillos");
        }
        else
        {
            Console.WriteLine("No usa palillos");
        }
    }
}

class Triangulito : InstrumentoMusicalDePercusion
{
    public float Medida { get; set; }

    public Triangulito(float medida, bool usaPalillos, string nombre, string tipo) : base(usaPalillos, nombre, tipo)
    {
        Medida = medida;
    }
    public void MostrarInfoTriangulo()
    {
        MostrarInfoPercusion();
        Console.WriteLine($"Medidas: {Medida}");
    }
}



class Guitarra : InstrumentoMusicalDeCuerda
{
    public Guitarra(int numerocuerda, string nombre, string tipo) : base(numerocuerda, nombre, tipo) { }
    
    public void MostrarInfoGuitarra()
    {
        MostrarInfoCuerda();
    }   
    
}

class Piano : InstrumentoMusicalDeCuerda
{
    public int NumeroTeclas { get; set; }
    public Piano(int numeroTeclas, int numerocuerda, string nombre, string tipo) : base(numerocuerda, nombre, tipo) 
    { 
        NumeroTeclas = numeroTeclas;
    }

    public void MostrarInfoPiano()
    {
        MostrarInfoCuerda();
        Console.WriteLine($"Numero de teclas: {NumeroTeclas}");
    }

}

class Flauta : InstrumentoMusicalDeViento
{
    public Flauta(string nombre, string tipo, string material) : base(nombre, tipo, material) { }

    public void MostrarInfoFlauta()
    {
        MostrarInfoViento();
    }
}

class Program
{
    static void Main()
    {
        Guitarra guitarra = new Guitarra(6, "guitarrita", "Cuerda");
        guitarra.MostrarInfoGuitarra();
        Console.WriteLine("");
        Piano piano = new Piano(26, 26, "Pianito", "Cuerda");
        piano.MostrarInfoPiano();
        Console.WriteLine("");
        Flauta flauta = new Flauta("Viento", "Flautita", "Madera");
        flauta.MostrarInfoFlauta();
        Console.WriteLine("");
        Triangulito triangulito = new Triangulito(24, true, "Triangulitito", "Percusión");
        triangulito.MostrarInfoTriangulo();
        Console.WriteLine("");
        
    }
}

