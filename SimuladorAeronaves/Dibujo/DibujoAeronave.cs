
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
        public void Dibujar(Graphics g, PointF[] vertices, int ancho, int alto, float escala)
        {
            // Comprobamos que existan puntos para dibujar
            if (vertices == null || vertices.Length < 3 || escala <= 0)
            {
                return;
            }

            // Calculamos el centro del panel
            float centroX = ancho / 2f;
            float centroY = alto / 2f;

            // Guardamos los puntos que se dibujaran en pantalla
            PointF[] puntos = new PointF[vertices.Length];

            for (int i = 0; i < vertices.Length; i++)
            {
                // Convertimos las coordenadas del plano a la pantalla
                float x = centroX + vertices[i].X * escala;
                float y = centroY - vertices[i].Y * escala;

                puntos[i] = new PointF(x, y);
            }

            // Dibujamos la aeronave utilizando sus vertices
            using (Brush pincel = new SolidBrush(Color.FromArgb(26, 152, 194)))
            using (Pen lapiz = new Pen(Color.FromArgb(180, 235, 250), 2))
            {
                g.FillPolygon(pincel, puntos);
                g.DrawPolygon(lapiz, puntos);
            }
        }
    }
}

