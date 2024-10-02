
namespace PruebaTecnica.Models
{
    public class MisionCasiImposible : Mision
    {
        //acciones necesarias para completar la mision
        public List<string> accionesRequeridas { get; private set; } = new List<string>();
        public MisionCasiImposible(string nombre, string dificultad, int  puntosEXRecompensa, int minimoPuntosEXRequeridos) : base(nombre, dificultad, puntosEXRecompensa, minimoPuntosEXRequeridos)
        {

        }
        //agregar accion a accionesRequeridas
        public bool addAccionRequerida(string accion)
        {
            if (accion == null || accionesRequeridas.Contains(accion))
            {
                return false;
            }
            else
            {
                accionesRequeridas.Add(accion);
                return true;
            }
        }
    }
}
