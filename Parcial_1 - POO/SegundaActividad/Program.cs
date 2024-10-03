using SegundaActividad.Modulos;

class Program
{
    static void Main()
    {
        Flor Rosa = new Flor("Rosa", 10);
        Flor Jazmin = new Flor("Jazmin", 15);
        Flor Camelia = new Flor("Camelia", 20);
        List<Flor> Arreglo = new List<Flor>();
        Arreglo.Add(Jazmin);
        Arreglo.Add(Camelia);
        Arreglo.Add(Rosa);
        ArregloFloral ArregloFloral1 = new ArregloFloral(Arreglo);
        Arreglo.Remove(Jazmin);
        ArregloFloral ArregloFloral2 = new ArregloFloral(Arreglo);
        Arreglo.Remove(Camelia);
        ArregloFloral ArregloFloral4 = new ArregloFloral(Arreglo);
        Pedido Pedido = new Pedido(ArregloFloral1);
        Cliente Cliente = new Cliente("Lucas", Pedido);
        Cliente.MostrarResumenPedido();

        ArregloFloral1.AgregarFlor(Rosa);
        Pedido.AgregarArreglo(ArregloFloral1);
        Pedido.AgregarArreglo(ArregloFloral2);
        Pedido.AgregarArreglo(ArregloFloral2);
        Pedido.AgregarArreglo(ArregloFloral2);
        Pedido.AgregarArreglo(ArregloFloral2);
        Cliente Cliente_2 = new Cliente("Antonio", Pedido);
        Console.WriteLine();
        Cliente_2.MostrarResumenPedido();
    }
}