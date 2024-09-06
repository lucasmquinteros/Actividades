/*SUPERMERCADO: 
En el super "Compras felices" se ha decidido implementar un sistema para gestionar el inventario de productoSSSS y las ordeneSS 
de compraSS de los clienteSSS.
Los productoSS se categorizan en diferentes seccioneSSS como: frutas; verduras; lacteos; carnes. Cada producto
tiene un código, nombre, cant. en stock y precio.
Además se requiere gestionar las ordenes de compras, que contienen multiples productos y
deben calcular el total de la orden.
 */

class Producto
{
    public string Codigo { get; private set; }
    public string Nombre { get; private set; }
    public int CantidadStock
    {
        get
        {
            if (CantidadStock > 1)
            {
                return CantidadStock;
            }
            else
            {
                Console.WriteLine("no hay suficiente stock");
                return CantidadStock;
            }
        }
        private set { }
    }
    public Decimal Precio { get; private set; }



    public Producto(string codigo, string nombre, int cantidadStock, decimal precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        CantidadStock = cantidadStock;
        Precio = precio;
    }

    public void ActualizarStock(int cantidad)
    {
        int.TryParse(Console.ReadLine(), out cantidad);
        CantidadStock += cantidad;
    }
}

class OrdenCompra
{
    private List<Producto> _productos;

    public OrdenCompra()
    {
        _productos = new List<Producto>();
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var p in _productos)
        {
            total += p.Precio;
        }
        return total;
    }

    public void MostrarDetallesPedido()
    {
        Console.WriteLine($"Detalles de la orden de compra:");
        foreach (var prod in _productos)
        {
            Console.WriteLine($"Producto: {prod.Nombre}, Precio: {prod.Precio}");
        }
        Console.WriteLine($"Total: {CalcularTotal():C}");
    }

    public void AgregarProducto(Producto producto)
    {
        _productos.Add(producto);
    }
    public void QuitarProducto(Producto producto)
    {
        Console.WriteLine($"Se elimino el producto: {producto}");
        _productos.Remove(producto);
    }
    public void QuitarTodo()
    {
        _productos.Clear();
        Console.WriteLine("Se eliminaron todos los productos...\n");
    }

    public int MostrarOpciones(int Opcion)
    {
        Console.WriteLine("\nQue desea hacer?");
        Console.WriteLine("Ingrese 1 si quiere agregar un nuevo producto");
        Console.WriteLine("Ingrese 2 si quiere eliminar un producto");
        Console.WriteLine("Ingrese 3 si quiere eliminar todo");
        Console.WriteLine("Ingrese 4 si quiere ver el total");
        Console.WriteLine("Ingrese 5 si quiere ver los detalles de la orden");
        Console.WriteLine("Si no ingresa nada o ingresa 0 terminara la ordden\n");
        int.TryParse(Console.ReadLine(), out Opcion);
        Console.WriteLine();
        return Opcion;
    }

}

class Program
{
    static void Main()
    {
        Producto Frutas = new Producto("lala", "Frutas", 5, 50);
        Producto Verduras = new Producto("codigo", "Verduritas", 2, 20);
        Producto Lacteos = new Producto("224", "Lechita", 9, 100);
        Producto Carnes = new Producto("223", "pollo", 1, 500);

        OrdenCompra ordenCompra = new OrdenCompra();

        int Opcion = 1;
        ordenCompra.MostrarOpciones(Opcion);
        while (Opcion != 0 && Opcion < 6)
        {
            
            switch (Opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el tipo de producto que desea agregar:\n1-Fruta\n2-Verdura\n3-Lacteo\n4-Carnes");
                    int.TryParse(Console.ReadLine(), out Opcion);
                    switch (Opcion)
                    {
                        case 1:
                            ordenCompra.AgregarProducto(Frutas);
                            break;
                        case 2:
                            ordenCompra.AgregarProducto(Verduras);
                            break;
                        case 3:
                            ordenCompra.AgregarProducto(Lacteos);
                            break;
                        case 4:
                            ordenCompra.AgregarProducto(Carnes);
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Ingrese el tipo de producto que desea eliminar:\n1-Fruta\n2-Verdura\n3-Lacteo\n4-Carnes");
                    int.TryParse(Console.ReadLine(), out Opcion);
                    switch (Opcion)
                    {
                        case 1:
                            ordenCompra.QuitarProducto(Frutas);
                            break;
                        case 2:
                            ordenCompra.QuitarProducto(Verduras);
                            break;
                        case 3:
                            ordenCompra.QuitarProducto(Lacteos);
                            break;
                        case 4:
                            ordenCompra.QuitarProducto(Carnes);
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                    break;
                case 3:
                    ordenCompra.QuitarTodo();
                    break;
                case 4:
                    Console.WriteLine($"El total de la orden es: {ordenCompra.CalcularTotal():C}");
                    break;
                case 5:
                    ordenCompra.MostrarDetallesPedido();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            ordenCompra.MostrarOpciones(Opcion);
        }
    }
}