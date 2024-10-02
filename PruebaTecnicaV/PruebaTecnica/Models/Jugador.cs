using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class Jugador
    {
        public string Nombre { get; private set; }
        public Aventura Aventura { get; private set; }
        public List<string> misionesSuperadas { get; private set; } = new List<string>();
        public int puntosExperienciaAcomulados { get; private set; }
        public List<string> AccionesRealizadas { get; private set; } = new List<string>();
        public Jugador(string nombre, Aventura aventura)
        {
            Nombre = nombre;
            Aventura = aventura;
        }
        //agregar una accion a la lista de acciones
        public bool addAccion(string elemento) {
            if(elemento == null || AccionesRealizadas.Contains(elemento))
            {
                return false;
            }
            else
            {
                AccionesRealizadas.Add(elemento);
                return true;
            }
        }
        //realizar accion: 
        public Boolean realizoAccion(string elemento)
        {
            if (AccionesRealizadas.Contains(elemento))
            {
                return true;
            }
            else {
                return false;
            }
        }
        //agregar una mision superada
        public Boolean addMisionSuperada(string mision)
        {
            if (!misionesSuperadas.Contains(mision) && Aventura.Misiones[mision].superaMision(this))
            {
                misionesSuperadas.Add(mision);
                Console.WriteLine("Mision Completada!");
                return true;
            }
            else
            {
                Console.WriteLine("No tiene suficiente puntos de XP");
                return false;
            }
        }
        //al terminar una mision incremento mis puntos de XP
        public void incrementarPuntosDeExperiencia(int puntoEx)
        {
            puntosExperienciaAcomulados += puntoEx;
        }
        //obtener los puntos de experiencia para saber si el jugador es apto para superar la mision
        public int getPuntosExperienciaAcomulados()
        {
            return puntosExperienciaAcomulados;
        }
        //obtener la cantidad de misiones superadas
        public int getCantidadMisionesSuperadas()
        {
            return misionesSuperadas.Count();
        }
        //validar si dos instancias de jugadores son iguales
        public Boolean equals(object O)
        {
            if(O == null || O is Jugador)
            {
                return false;
            }
            Jugador otroJugador = (Jugador)O;
            bool nombreIgual = this.Nombre == otroJugador.Nombre;

            return nombreIgual;
        }

    }
}
