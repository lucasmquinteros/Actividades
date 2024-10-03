
class Program
{
    static void Main()
    {
        Stack<string> historial = new Stack<string>();
        int opcion;
        
        do
        {
            Console.WriteLine("1. Visitar nueva pagina");
            Console.WriteLine("2. Retroceder pagina");
            Console.WriteLine("3. Mostrar Historial");
            Console.WriteLine("4. Salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (opcion)
            {
                case 1:
                    Console.Write("\nIngrese el URL a visitar: ");
                    string url = Console.ReadLine();
                    historial.Push(url);
                    Console.WriteLine($"Visitando: {url}\n");
                    break;
                case 2:
                    if(historial.Count > 0)
                    {
                        string paginaAnterior = historial.Pop();
                        Console.WriteLine($"Retrocediendo desde: {paginaAnterior}\n");
                    }
                    else
                    {
                        Console.WriteLine("No hay mas paginas en el historial");
                    }
                    break;
                case 3:
                    Console.WriteLine("Historial de Navegacón: ");
                    foreach(var pagina in historial)
                    {
                        Console.WriteLine(pagina);
                    }
                    Console.WriteLine();
                    break;
            }
        } while (opcion != 4);
        Console.WriteLine("Pulse cualquier tecla para salir: ");
        Console.ReadKey();

    }
}