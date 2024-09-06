using ASDASD.Enums;

namespace ASDASD.Modelos
{
    public class Reserva
    {
        private static int Reservas = 0;
        public int Numero { get; private set; }
        public Hotel Hotel { get; set; }
        public List<Habitacion> Habitaciones { get; set; } = new List<Habitacion>();
        public DateTime FechaDeReserva { get; set; }
        public string MetodoPago { get; set; }

        public Reserva(Hotel hotel, Habitacion habitacion, DateTime fechaReserva,string metodoPago) {
            Hotel = hotel;
            Habitaciones.Add(habitacion);
            FechaDeReserva = fechaReserva;
            MetodoPago = metodoPago;
            Numero = ++Reservas;
        }
        public Reserva(Hotel hotel, List<Habitacion>habitaciones, DateTime fechaReserva, string metodoPago)
        {
            Hotel = hotel;
            if(habitaciones.Count <= 0)
            {
                throw new ArgumentException("La lista de habitaciones no debe ser vacias");
            }
            FechaDeReserva = fechaReserva;
            MetodoPago = metodoPago;
            Numero = ++Reservas;
        }
        public double CalcularCostoServicios()
        {
            double costoServicio = 0;
            double totalTarifasHabitacion = 0;
            foreach(var habitacion in Habitaciones)
            {
                totalTarifasHabitacion += habitacion.CalcularTarifa(Hotel.Temporada);
                foreach (var servicio in habitacion.Servicios)
                {
                    costoServicio += servicio.Costo;
                }
            }
            return totalTarifasHabitacion + costoServicio;
        }
    }

}
