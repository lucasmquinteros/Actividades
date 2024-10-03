
using System.Reflection.Metadata.Ecma335;

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
        //actividad 2, implementar un metodo donde el jugador tenga suficiente XP para realizar la mision y si realizo todas las acciones necesarias.
        public override bool superaMision(Jugador jugador)
        {
            int contador = 0;
            foreach (var accion in jugador.AccionesRealizadas) {
                if (accionesRequeridas.Contains(accion))
                {
                    contador++;
                }
            }
            return base.superaMision(jugador) && contador == accionesRequeridas.Count();
        }
    }
}
