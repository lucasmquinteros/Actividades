using Parcial.Interfaz;

namespace Parcial.Modulos
{
    public class Miembro : Imostrable
    {
        public string Nombre { get; private set; }
        public int NumeroMiembro { get
            {
                return num++;
            }
        }
        public static int num { get; private set; } = 0;
        public Miembro(string nombre)
        {
            Nombre = nombre;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Miembro: {Nombre} | Numero de miembro: {NumeroMiembro}");
        }
    }
}
