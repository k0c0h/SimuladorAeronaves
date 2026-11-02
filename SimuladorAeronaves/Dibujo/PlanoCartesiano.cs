using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SimuladorAeronaves.Dibujo
{
    internal class PlanoCartesiano
    {
        public void Dibujar(Graphics g, int ancho, int alto)
        {
            // Para que las lineas se vean mejor
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Calculamos el centro del panel
            float centroX = ancho / 2f;
            float centroY = alto / 2f;

            // Distancia entre las lineas del plano
            int separacion = 50;

            // Colores para el dibujo
            using (Pen lapizCuadricula = new Pen(Color.FromArgb(35, 55, 75), 1))
            using (Pen lapizEjes = new Pen(Color.FromArgb(80, 200, 230), 2))
            using (Brush pincelTexto = new SolidBrush(Color.White))
            using (Font letra = new Font("Segoe UI", 9))
            {
                // Calculamos las lineas verticales
                for (float x = centroX; x < ancho; x += separacion)
                {
                    g.DrawLine(lapizCuadricula, x, 0, x, alto);
                }

                for (float x = centroX - separacion; x >= 0; x -= separacion)
                {
                    g.DrawLine(lapizCuadricula, x, 0, x, alto);
                }

                // Calculamos las lineas horizontales
                for (float y = centroY; y < alto; y += separacion)
                {
                    g.DrawLine(lapizCuadricula, 0, y, ancho, y);
                }

                for (float y = centroY - separacion; y >= 0; y -= separacion)
                {
                    g.DrawLine(lapizCuadricula, 0, y, ancho, y);
                }

                // Dibujamos los ejes principales
                g.DrawLine(lapizEjes, 0, centroY, ancho, centroY);
                g.DrawLine(lapizEjes, centroX, 0, centroX, alto);

                // Colocamos los nombres de los ejes
                g.DrawString("X", letra, pincelTexto, ancho - 20, centroY - 22);
                g.DrawString("Y", letra, pincelTexto, centroX + 8, 5);

                // Marcamos el origen del plano
                g.DrawString("(0,0)", letra, pincelTexto, centroX + 5, centroY + 5);
            }
        }
    }
}
