class Producto
{
    private string _nombre;
    private decimal _precio;
    private int _cantidadEnStock;

    public Producto(string nombre, decimal precio, int cantidadEnStock)
    {
        _nombre = nombre;
        _precio = precio;
        _cantidadEnStock = cantidadEnStock;
    }
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    public decimal Precio
    {
        get { return _precio; }
        set { _precio = value; }
    }
    public int CantidadEnStock
    {
        get { return _cantidadEnStock; }
        private set { _cantidadEnStock = value; }
    }

    public void ActualizarCantidadEnStock(int cantidad)
    {
        if(CantidadEnStock + cantidad >= 0)
        {
            CantidadEnStock += cantidad;
            Console.WriteLine($"Cantidad en stock actualizado: {CantidadEnStock}");
        }
        else
        {
            Console.WriteLine("Cantidad no valida para actualizar el stock.");
        }
    }
}

class Program
{
    static void Main()
    {
        Producto producto = new Producto("Laptop", 500, 50);
        Console.WriteLine($"Nombre: {producto.Nombre}");
        Console.WriteLine($"Precio: {producto.Precio}");
        Console.WriteLine($"Cantidad en stock: {producto.Nombre}");

        producto.ActualizarCantidadEnStock(20);
        producto.ActualizarCantidadEnStock(-70);
        
    }
}