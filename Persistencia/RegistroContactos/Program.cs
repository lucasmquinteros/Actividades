using RegistroContactos.modulos;

namespace Contacto
{
    public class Program
    {
        static void Main()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("1. Agregar Contacto.");
                Console.WriteLine("2. Mostrar Contactos.");
                Console.WriteLine("3. Guardar y salir.");

                Console.Write("Ingrese la opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Sistema.AgregarContacto();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Sistema.MostrarContactos();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("Saliendo..");
                        Console.WriteLine("\n");
                        break;
                }
            } while (opcion != 5);
        }
    }
}