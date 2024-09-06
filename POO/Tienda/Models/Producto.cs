using Tienda.Enumeration;

namespace Tienda.Models
{
    public class Producto
    {
        public Categoria Categoria { get; set; }
        public string Nombre { get; private set; }
        public double Precio { get; set; }
        public Producto(Categoria categoria, string nombre, double precio) {
            Categoria = categoria;
            Nombre = nombre;
            Precio = precio;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"El producto: {Nombre}, Pertenece a la categoria de {Categoria}");
            Console.WriteLine($"Precio: {Precio}");
        }
    }
}
