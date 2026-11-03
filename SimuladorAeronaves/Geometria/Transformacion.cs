using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAeronaves.Geometria
{
    public static class Transformacion
    {
        public static Matriz3x3 Traslacion(double dx, double dy)
        {
            return new Matriz3x3(new double[,] {
                { 1, 0, dx },
                { 0, 1, dy },
                { 0, 0, 1  }
            });
        }

        public static Matriz3x3 Rotacion(double anguloGrados)
        {
            double rad = anguloGrados * Math.PI / 180.0;
            double cos = Math.Cos(rad);
            double sin = Math.Sin(rad);

            return new Matriz3x3(new double[,] {
                { cos, -sin, 0 },
                { sin,  cos, 0 },
                { 0,    0,   1 }
            });
        }

        public static Matriz3x3 Escalamiento(double sx, double sy)
        {
            return new Matriz3x3(new double[,] {
                { sx, 0,  0 },
                { 0,  sy, 0 },
                { 0,  0,  1 }
            });
        }
    }
}