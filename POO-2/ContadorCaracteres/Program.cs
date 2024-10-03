class Program
{
    static void Main()
    {
        Stack<char> pila = new Stack<char>();

        Console.Write("Escriba la frase: ");
        string frase = Console.ReadLine();

        foreach(var cadaLetra in frase)
        {
            pila.Push(cadaLetra);
        }

        Console.WriteLine("Frase invertida: ");

        while(pila.Count > 0) {
            Console.Write(pila.Pop());
        }
    }
}