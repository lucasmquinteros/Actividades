using System.Threading;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el texto: ");
        string Texto = Console.ReadLine();
        IDictionary<string, int> contadorPalabras = new Dictionary<string, int>();
        string[] palabras = Texto.ToLower().Split(' ');

        foreach (string palabra in palabras)
        {
            if (contadorPalabras.ContainsKey(palabra))
            {
                contadorPalabras[palabra]++;
            }
            else
            {
            contadorPalabras.Add(palabra, 1);
            }
        }
        Console.WriteLine("\n");
        Console.WriteLine("Frecuencia de palabras: ");
        foreach (var entrada in contadorPalabras)
        {
            Console.WriteLine($"{entrada.Key}: {entrada.Value}");
        }

    }
}