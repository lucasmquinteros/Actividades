using System;

public class Producto
{
    public int Codigo { get; private set; }
    public string Nombre { get; private set; }
    public int Cantidad { get; private set; }
    public Producto(int codigo, string nombre, int cantidad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Cantidad = cantidad;
    }
    public void ActualizarStock(int cantidad)
    {
        Cantidad = cantidad;
    }
}
public class Program
{
    static void Main()
    {
        int opcion;
        IDictionary<int, Producto> almacen = new Dictionary<int, Producto>();

        do
        {
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Actualizar stock");
            Console.WriteLine("3. Mostrar los producto en stock");
            Console.WriteLine("4. Salir\n");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el código del producto: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el nombre del producto: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese la cantidad del producto: ");
                    int cantidad = int.Parse(Console.ReadLine());
                    Producto p = new Producto(codigo, nombre, cantidad);
                    almacen.TryAdd(codigo, p);
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Console.Write("Ingrese el codigo del producto que quiere actualizar: ");
                    int cod = int.Parse(Console.ReadLine());
                    if (almacen.ContainsKey(cod))
                    {
                        Console.Write("Ingrese la nueva cantidad del producto: ");
                        int cant = int.Parse(Console.ReadLine());
                        almacen[cod].ActualizarStock(cant);
                        Console.WriteLine("Cantidad actualizada.");
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado.");
                    }
                    Console.WriteLine("\n");
                    break;
                case 3:
                    Console.WriteLine("Productos en stock: ");
                    foreach(var pr in almacen.Values)
                    {
                        Console.WriteLine($"Codigo: {pr.Codigo}, Nombre: {pr.Nombre}, Cantidad: {pr.Cantidad}");
                    }
                    Console.WriteLine("\n");
                    break;
            }
        } while (opcion != 4);
    }
}