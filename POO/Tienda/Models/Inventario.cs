using Tienda.Enumeration;

namespace Tienda.Models
{
    public class Inventario
    {
        public List<Producto> Productos { get; private set; } = new List<Producto>();

        public Inventario(List<Producto> products) { Productos = products; }
        public void AgregarProducto(Producto producto) { Productos.Add(producto);}
        public void QuitarProducto(Producto producto) { Productos.Remove(producto);}
        public void ConsultarProducto(Producto producto) { producto.MostrarDetalles(); }
        public void ActualizarLista(List<Producto> lista) { Productos =  lista; }
        public void MostrarDetalles()
        {
            foreach (var producto in Productos)
            {
                producto.MostrarDetalles();
            }
        }
        
    }
}
