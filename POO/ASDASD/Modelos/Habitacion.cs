using ASDASD.Enums;

namespace ASDASD.Modelos
{
    public class Habitacion
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public List<Servicio> Servicios { get; set; } = new List<Servicio>();
        public double TarifaBase { get; set; }
        public Habitacion(int numero, string tipo, List<Servicio> servicios, double tarifaBase)
        {
            Numero = numero;
            Tipo = tipo;
            TarifaBase = tarifaBase;
        }

        public void AgregarServicio(Servicio servicio)
        {
            Servicios.Add(servicio);
        }
        public double CalcularTarifa(Temporada temporada)
        {
            if(temporada == Temporada.Alta)
            {
                return TarifaBase * 1.5;
            }
            return TarifaBase;
            
        }
    }
}
