using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAeronaves.Geometria
{
    public class Punto2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punto2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}