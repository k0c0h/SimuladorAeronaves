using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorAeronaves.Geometria;

namespace SimuladorAeronaves.Modelos
{
    public class Aeronave
    {
        public List<Punto2D> VerticesLocales { get; set; }
        public Punto2D PosicionActual { get; set; }
        public double AnguloActual { get; set; }

        public Aeronave(double xInicial, double yInicial)
        {
            PosicionActual = new Punto2D(xInicial, yInicial);
            AnguloActual = 0;

            VerticesLocales = new List<Punto2D>
            {
                new Punto2D(0, -28),  
                new Punto2D(4, -14),   
                new Punto2D(22, -4),   
                new Punto2D(8, 3),     
                new Punto2D(12, 20),   
                new Punto2D(0, 12),     
                new Punto2D(-12, 20),  
                new Punto2D(-8, 3),    
                new Punto2D(-22, -4),  
                new Punto2D(-4, -14)   
            };
        }

        public List<Punto2D> ObtenerVerticesTransformados()
        {
            List<Punto2D> verticesTransformados = new List<Punto2D>();

            Matriz3x3 matRot = Transformacion.Rotacion(AnguloActual);
            Matriz3x3 matTras = Transformacion.Traslacion(PosicionActual.X, PosicionActual.Y);
            Matriz3x3 matTotal = Matriz3x3.Multiplicar(matTras, matRot);

            foreach (var v in VerticesLocales)
            {
                Punto2D pTrans = matTotal.MultiplicarPunto(v);
                verticesTransformados.Add(pTrans);
            }

            return verticesTransformados;
        }
    }
}