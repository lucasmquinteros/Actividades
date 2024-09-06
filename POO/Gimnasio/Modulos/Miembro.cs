using Gimnasio.enums;
using System.Text.RegularExpressions;

namespace Gimnasio.Modulos
{
    public class Miembro
    {
        public string Nombre { get; private set; }
        public TipoMembresia Membresia { get; private set; }
        public double CostoBaseMembresia
        {
            get
            {
                switch (Membresia)
                {
                    case TipoMembresia.Basico:
                        return 30;
                    case TipoMembresia.Premium:
                        return 50;
                    case TipoMembresia.VIP:
                        return 80;
                    default:
                        return 0;
                }
            }
        }
        public List<ClaseAdicional> ClasesAdicionales { get; private set; } = new List<ClaseAdicional>();

        public bool AccesoPsicina
        {
            get { return Membresia != TipoMembresia.Basico; }
        }
        public bool AccesoSpa => Membresia == TipoMembresia.VIP;
        public bool AccesoClasesGrupales => Membresia == TipoMembresia.Premium;

        public double DescuentoEnClases {
            get{
                if (Membresia == TipoMembresia.Premium) return 0.1;
                else if (Membresia == TipoMembresia.Premium) return 0.1;
                return 0;
            } 
        }
        public double CostoTotalClases
        {
            get
            {
                double costoTotal = 0;
                foreach(var clase in ClasesAdicionales)
                {
                    costoTotal += clase.Costo * (1 - DescuentoEnClases);
                }
                return costoTotal;
            }
        }
        public double CostoMensualTotal => CostoBaseMembresia + CostoTotalClases;
        public Miembro(string nombre, TipoMembresia membresia)
        {
            Nombre = nombre;
            Membresia = membresia;
        }
        public void MostrarDetallesMembresia()
        {

        }
    }
}
