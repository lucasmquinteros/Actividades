namespace SegundaActividad.Modulos
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public Pedido Pedido { get; private set; }
        public Cliente(string nombre, Pedido pedido)
        {
            Nombre = nombre;
            Pedido = pedido;
        }
        public void MostrarResumenPedido()
        {
            Console.WriteLine($"Cliente: {Nombre} | Total sin descuento {Pedido.Total}\nTotal con descuento {Pedido.Total * 0.9}");
            if( Pedido.DescuentoAplicado == true )
            {
                Console.WriteLine("Descuento Aplicado");
            }
            else
            {
                Console.WriteLine("No cumple requisitos para descuento");
            }
        }
    }
}
