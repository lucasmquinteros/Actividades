using ASDASD.Enums;

namespace ASDASD.Modelos
{
    public class Hotel
    {
        public string Nombre { get; set; }
        public Temporada Temporada { get; set; }
        public List<Habitacion> Habitaciones { get; set; } = new List<Habitacion>();

        public Hotel(string nombre, Temporada temporada) {
            Nombre = nombre;
            Temporada = temporada;
        }

        public void AgregarHabitaciones(Habitacion habitacion)
        {
            Habitaciones.Add(habitacion);
        }


    }
}
