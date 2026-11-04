
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimuladorAeronaves.Dibujo
{
    internal class DibujoAeronave
    {
        public void Dibujar(
            Graphics g,
            PointF[] vertices,
            int ancho,
            int alto,
            float escala,
            bool seleccionada)
        {
            if (vertices == null || vertices.Length < 3 || escala <= 0)
            {
                return;
            }

            float centroX = ancho / 2f;
            float centroY = alto / 2f;

            PointF[] puntos = new PointF[vertices.Length];

            for (int i = 0; i < vertices.Length; i++)
            {
                float x = centroX + vertices[i].X * escala;
                float y = centroY - vertices[i].Y * escala;

                puntos[i] = new PointF(x, y);
            }

            // La aeronave se construye con varios polígonos: fuselaje, alas y cola.
            PointF[] fuselaje = ObtenerPoligono(puntos, 0, 1, 3, 5, 7, 9);
            PointF[] alas = ObtenerPoligono(puntos, 1, 2, 3, 7, 8, 9);
            PointF[] estabilizadores = ObtenerPoligono(puntos, 3, 4, 5, 6, 7);
            Color colorContorno = seleccionada
                ? Color.Yellow
                : Color.FromArgb(180, 235, 250);

            using (Brush pincelFuselaje = new SolidBrush(Color.FromArgb(26, 152, 194)))
            {
                using (Brush pincelAlas = new SolidBrush(Color.FromArgb(35, 122, 170)))
                {
                    using (Brush pincelCola = new SolidBrush(Color.FromArgb(45, 104, 150)))
                    {
                        using (Pen lapiz = new Pen(colorContorno, seleccionada ? 3 : 2))
                        {
                            g.FillPolygon(pincelAlas, alas);
                            g.FillPolygon(pincelCola, estabilizadores);
                            g.FillPolygon(pincelFuselaje, fuselaje);
                            g.DrawPolygon(lapiz, puntos);

                            // La linea central permite distinguir el fuselaje y la direccion de vuelo.
                            using (Pen lapizFuselaje = new Pen(Color.FromArgb(220, 250, 255), 2))
                            {
                                PointF nariz = puntos[0];
                                PointF cola = puntos[5];
                                g.DrawLine(lapizFuselaje, nariz, cola);
                            }
                        }
                    }
                }
            }
        }

        private PointF[] ObtenerPoligono(PointF[] puntos, params int[] indices)
        {
            PointF[] poligono = new PointF[indices.Length];

            for (int i = 0; i < indices.Length; i++)
            {
                poligono[i] = puntos[indices[i]];
            }

            return poligono;
        }
    }
}

