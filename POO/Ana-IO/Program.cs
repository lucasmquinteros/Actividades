/*
 * Contexto: Ana es una bibliotecaria que quiere modernizar el sistema de registro de libros en su biblioteca.
 * Ella necesita un programa que permita registrar información detallada sobre cada libro y luego poder consultarla facilmente.
Enunciado: el programa debe solicitar al usuario que ingrese el titulo del libro, el autor, el genero y el num de paginas. 
Despues de ingresar estos datos, el programa debe mostrar toda la info del libro en un formato claro y ordenado
*/

class Publicacion
{
    public string Titulo { get; set; }

    public string Autor { get; set; }

    public Publicacion(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public void MostrarInfo()
    {
        Console.Write($"Titulo: {Titulo}\nAutor: {Autor}\n");
    }

}

class Libro : Publicacion
{
    public string Genero { get; set; }

    public int NumeroPaginas { get; set; }

    public Libro(string titulo, string autor, string genero, int numeroPaginas) : base(titulo, autor)
    {

        Genero = genero;
        NumeroPaginas = numeroPaginas;
    }  

    public void MostrarInfoLibro()
    {
        MostrarInfo();
        Console.WriteLine($"Genero: {Genero}\nNumero de paginas: {NumeroPaginas}");
    }
}


class Program
{
    static void Main()
    {
        string Titulo, Autor, Genero;
        int NumeroHojas;

        Console.Write("Ingrese el Titulo: ");
        Titulo = Console.ReadLine();

        Console.Write("Ingrese el autor: ");
        Autor = Console.ReadLine();

        Console.Write("Ingrese el Genero: ");
        Genero = Console.ReadLine();

        Console.Write("Ingrese la cantidad de hojas: ");
        int.TryParse(Console.ReadLine(), out NumeroHojas);

        Console.WriteLine();

        Libro libro = new Libro(Titulo, Autor, Genero, NumeroHojas);

        libro.MostrarInfoLibro();
    }
}
