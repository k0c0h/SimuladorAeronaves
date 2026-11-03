using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorAeronaves.Geometria;

namespace SimuladorAeronaves.Logica
{
    public class GestorRecorrido
    {
        private readonly List<Punto2D> posiciones =
            new List<Punto2D>();

        public void RegistrarPosicion(Punto2D posicion)
        {
            if (posicion == null)
                return;

            posiciones.Add(
                new Punto2D(posicion.X, posicion.Y));
        }

        public List<Punto2D> ObtenerRecorrido()
        {
            return new List<Punto2D>(posiciones);
        }

        public int CantidadPosiciones()
        {
            return posiciones.Count;
        }

        public bool TieneRecorrido()
        {
            return posiciones.Count > 0;
        }

        public void LimpiarRecorrido()
        {
            posiciones.Clear();
        }
    }
}