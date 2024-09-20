public class Ticket
{
    public int Id { get; private set; }
    public string Descripcion { get; private set; }
    public Ticket(int id, string descripcion)
    {
        Id = id;
        Descripcion = descripcion;
    }
}
public class SistemaTickets
{
    private Queue<Ticket> _tickets = new Queue<Ticket>();
    private int siguienteID = 0;
    public Queue<Ticket> Tickets { get { return _tickets;} }
    public void AgregarTicket(string descripcion)
    {
        Ticket ticket = new Ticket(++siguienteID, descripcion);
        _tickets.Enqueue(ticket);
        Console.WriteLine($"Ticket #{ticket.Id} agregado: {ticket.Descripcion}");
    }
    public void ProcesarTicket()
    {
        if(_tickets.Count == 0)
        {
            Console.WriteLine("No hay mas tickets para procesar");
        }
        else
        {
            Ticket tic = _tickets.Dequeue();
            Console.WriteLine($"Procesando el ticket: {tic.Id} | {tic.Descripcion}");
        }
    }
    public void MostrarTickets()
    {
        if (_tickets.Count == 0)
        {
            Console.WriteLine("No hay mas tickets pendientes");
        }
        else
        {
            Console.WriteLine($"Pendientes: ");
            foreach (var ticket in Tickets)
            {
                Console.WriteLine($"{ticket.Id} | {ticket.Descripcion}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int opcion;
        SistemaTickets sistema = new SistemaTickets();
        do
        {

            Console.WriteLine("=== Menu de Opciones ===");
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
                    Console.Write("Ingrese la descripcion del ticket: ");
                    string descripcion = Console.ReadLine();
                    sistema.AgregarTicket(descripcion);
                    Console.WriteLine("\n");
                    break;
                case 2:
                    sistema.ProcesarTicket();
                    Console.WriteLine("\n");
                    break;
                case 3:
                    sistema.MostrarTickets();
                    Console.WriteLine("\n");
                    break;
                case 4:
                    Console.WriteLine("Saliendo");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        } while (opcion != 4);
    }
}