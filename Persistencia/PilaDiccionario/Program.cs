/*  Un editor de textos quiere implementar una funcionalidad para contar la frecuencia de las palabras en un artículo.

El sistema debe:
1. Leer una cadena de texto y separar las palabras.
2. Contar cuántas veces aparece cada palabra.
3. Mostrar la lista de palabras junto con su frecuencia.  */
public static class Sistema
{
    static Stack<Dictionary<string, int>> Palabras = new Stack<Dictionary<string, int>>();
    static readonly string archivo = "usuarios.txt";
    static readonly string fraseSeparador = "-";
    public static void AgregarFrase()
    {
        Console.Write("Ingrese la nueva frase: ");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ');
        Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();
        foreach (string palabra in palabras)
        {
            if (contadorPalabras.ContainsKey(palabra))
            {
                contadorPalabras[palabra] += 1;
            }
            else
            {
                contadorPalabras.Add(palabra, 0);
            }
        }
        Palabras.Push(contadorPalabras);
        Console.WriteLine($"\n");
    }
    public static void MostrarFrecuenciaDeFrase()
    {
        Console.Write("Ingrese la frase que busca: ");
        string frase = Console.ReadLine();

        Console.WriteLine($"Frecuencia de palabras: ");

        foreach (Dictionary<string, int> diccionarios in Palabras)
        {
            foreach (string clave in diccionarios.Keys)
            {
                Console.WriteLine($"{clave}|{diccionarios[clave] + 1}");
            }
        }
    }
    public static void GuardarSistema()
    {
        using StreamWriter writer = new StreamWriter(archivo);
        foreach(var diccionario in Palabras)
        {
            foreach(var  clave in diccionario.Keys)
            {
                writer.WriteLine($"{clave}|{diccionario[clave]}");
            }
            writer.WriteLine(fraseSeparador);
        }
        Console.WriteLine("Datos guardados correctamente!");
    }
}
class Program
{
    static void Main()
    {
        /*
        Console.WriteLine("ingrese un texto:  ");
        string texto = Console.ReadLine();

        Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();
        string[] palabras = texto.Split(' ');
        foreach (string palabra in palabras)
        {
            if (contadorPalabras.ContainsKey(palabra))
            {
                contadorPalabras[palabra] += 1;
            }
            else
            {
                contadorPalabras.Add(palabra, 0);
            }
        }
        Console.WriteLine($"\n");
        Console.WriteLine($"Frecuencia de palabras: ");
        foreach (var entrada in contadorPalabras)
        {
            Console.WriteLine($"{entrada.Key}: {entrada.Value}");
        }*/
        Sistema.AgregarFrase();
        Sistema.MostrarFrecuenciaDeFrase();
        Sistema.GuardarSistema();
    }
}