using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAeronaves.Geometria
{
    public class Matriz3x3
    {
        public double[,] M { get; set; } = new double[3, 3];

        public Matriz3x3()
        {
            M = new double[,] {
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 }
            };
        }

        public Matriz3x3(double[,] valores)
        {
            M = valores;
        }

        public static Matriz3x3 Multiplicar(Matriz3x3 a, Matriz3x3 b)
        {
            double[,] resultado = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultado[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        resultado[i, j] += a.M[i, k] * b.M[k, j];
                    }
                }
            }
            return new Matriz3x3(resultado);
        }

        public Punto2D MultiplicarPunto(Punto2D p)
        {
            double x = M[0, 0] * p.X + M[0, 1] * p.Y + M[0, 2] * 1;
            double y = M[1, 0] * p.X + M[1, 1] * p.Y + M[1, 2] * 1;
            return new Punto2D(x, y);
        }
    }
}