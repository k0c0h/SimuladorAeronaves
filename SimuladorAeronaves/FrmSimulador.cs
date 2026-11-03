
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuladorAeronaves.Dibujo;
using SimuladorAeronaves.Geometria;
using SimuladorAeronaves.Logica;
using SimuladorAeronaves.Modelos;

namespace SimuladorAeronaves
{
    public partial class FrmSimulador : Form
    {
        private PlanoCartesiano plano = new PlanoCartesiano();
        private DibujoAeronave dibujoAeronave = new DibujoAeronave();
        private GestorRecorrido gestorRecorrido = new GestorRecorrido();
        private ValidadorDatos validador = new ValidadorDatos();
        private Aeronave aeronave;
        private PointF[] vectorDesplazamiento;
        private PointF[] verticesAeronave = null;

        public FrmSimulador()
        {
            InitializeComponent();

            pnlDibujo.Resize += pnlDibujo_Resize;

            aeronave = new Aeronave(0, 0);

            gestorRecorrido.RegistrarPosicion(aeronave.PosicionActual);

            ActualizarDibujoAeronave();
        }

        public void MostrarAeronave(PointF[] vertices)
        {
            verticesAeronave = vertices;

            pnlDibujo.Invalidate();
        }

        private void pnlDibujo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(pnlDibujo.BackColor);

            // Dibujar el plano cartesiano
            plano.Dibujar(
                g,
                pnlDibujo.Width,
                pnlDibujo.Height);

            float escala = 1.0f;
            float centroX = pnlDibujo.Width / 2f;
            float centroY = pnlDibujo.Height / 2f;

            // Dibujar el recorrido de la aeronave
            List<Punto2D> recorrido =
                gestorRecorrido.ObtenerRecorrido();

            if (recorrido.Count >= 2)
            {
                using (Pen lapizRecorrido =
                    new Pen(Color.OrangeRed, 2))
                {
                    for (int i = 1; i < recorrido.Count; i++)
                    {
                        PointF anterior = new PointF(
                            centroX + (float)recorrido[i - 1].X * escala,
                            centroY - (float)recorrido[i - 1].Y * escala);

                        PointF actual = new PointF(
                            centroX + (float)recorrido[i].X * escala,
                            centroY - (float)recorrido[i].Y * escala);

                        g.DrawLine(lapizRecorrido, anterior, actual);
                    }
                }
            }

            // Dibujar el vector del último desplazamiento
            if (vectorDesplazamiento != null &&
                vectorDesplazamiento.Length == 2)
            {
                PointF inicio = new PointF(
                    centroX + vectorDesplazamiento[0].X * escala,
                    centroY - vectorDesplazamiento[0].Y * escala);

                PointF fin = new PointF(
                    centroX + vectorDesplazamiento[1].X * escala,
                    centroY - vectorDesplazamiento[1].Y * escala);

                using (Pen lapizVector = new Pen(Color.Blue, 2))
                {
                    lapizVector.EndCap =
                        System.Drawing.Drawing2D.LineCap.ArrowAnchor;

                    g.DrawLine(lapizVector, inicio, fin);
                }
            }

            if (verticesAeronave != null)
            {
                dibujoAeronave.Dibujar(
                    g,
                    verticesAeronave,
                    pnlDibujo.Width,
                    pnlDibujo.Height,
                    escala);
            }

            DibujarCoordenadasAeronave(g, centroX, centroY, escala);
        }

        private void DibujarCoordenadasAeronave(
            Graphics g,
            float centroX,
            float centroY,
            float escala)
        {
            if (aeronave == null || aeronave.PosicionActual == null)
                return;

            PointF puntoPosicion = new PointF(
                centroX + (float)aeronave.PosicionActual.X * escala,
                centroY - (float)aeronave.PosicionActual.Y * escala);

            using (Brush pincelPunto = new SolidBrush(Color.Yellow))
            using (Pen lapizPunto = new Pen(Color.Black, 1))
            using (Brush pincelTexto = new SolidBrush(Color.White))
            using (Font fuente = new Font("Segoe UI", 9, FontStyle.Bold))
            {
                g.FillEllipse(
                    pincelPunto,
                    puntoPosicion.X - 4,
                    puntoPosicion.Y - 4,
                    8,
                    8);

                g.DrawEllipse(
                    lapizPunto,
                    puntoPosicion.X - 4,
                    puntoPosicion.Y - 4,
                    8,
                    8);

                string coordenadas = string.Format(
                    "({0:0.##}, {1:0.##})",
                    aeronave.PosicionActual.X,
                    aeronave.PosicionActual.Y);

                g.DrawString(
                    coordenadas,
                    fuente,
                    pincelTexto,
                    puntoPosicion.X + 8,
                    puntoPosicion.Y - 22);
            }
        }

        private void pnlDibujo_Resize(object sender, EventArgs e)
        {
            pnlDibujo.Invalidate();
        }

        private void ActualizarDibujoAeronave()
        {
            List<Punto2D> vertices =
                aeronave.ObtenerVerticesTransformados();

            verticesAeronave = new PointF[vertices.Count];

            for (int i = 0; i < vertices.Count; i++)
            {
                verticesAeronave[i] = new PointF(
                    (float)vertices[i].X,
                    (float)vertices[i].Y);
            }

            pnlDibujo.Invalidate();
        }

        private bool TrasladarAeronave(double dx, double dy)
        {
            if (aeronave == null)
                return false;

            double posicionAnteriorX = aeronave.PosicionActual.X;
            double posicionAnteriorY = aeronave.PosicionActual.Y;
            double nuevaX = posicionAnteriorX + dx;
            double nuevaY = posicionAnteriorY + dy;

            aeronave.PosicionActual = new Punto2D(nuevaX, nuevaY);

            gestorRecorrido.RegistrarPosicion(
                aeronave.PosicionActual);

            vectorDesplazamiento = new PointF[]
            {
                new PointF((float)posicionAnteriorX, (float)posicionAnteriorY),
                new PointF((float)nuevaX, (float)nuevaY)
            };

            ActualizarControlesPosicion();

            ActualizarDibujoAeronave();
            return true;
        }

        private bool RotarAeronave(double angulo)
        {
            if (aeronave == null)
                return false;

            aeronave.AnguloActual += angulo;

            ActualizarDibujoAeronave();
            return true;
        }

        private void ReiniciarRecorrido()
        {
            gestorRecorrido.LimpiarRecorrido();

            gestorRecorrido.RegistrarPosicion(
                aeronave.PosicionActual);

            vectorDesplazamiento = null;

            ActualizarDibujoAeronave();
        }

        private void ActualizarControlesPosicion()
        {
            if (aeronave == null)
                return;

            if (aeronave.PosicionActual.X >= (double)txtNumPosX.Minimum &&
                aeronave.PosicionActual.X <= (double)txtNumPosX.Maximum)
            {
                txtNumPosX.Value = (decimal)aeronave.PosicionActual.X;
            }

            if (aeronave.PosicionActual.Y >= (double)txtNumPosY.Minimum &&
                aeronave.PosicionActual.Y <= (double)txtNumPosY.Maximum)
            {
                txtNumPosY.Value = (decimal)aeronave.PosicionActual.Y;
            }
        }

        private void btnTrasladar_Click(object sender, EventArgs e)
        {
            double dx, dy;
            string mensaje;

            if (!validador.ValidarDesplazamiento(
                txtNumDesplX.Text,
                txtNumDesplY.Text,
                out dx,
                out dy,
                out mensaje))
            {
                MessageBox.Show(
                    mensaje,
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            TrasladarAeronave(dx, dy);
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            double angulo;
            string mensaje;

            if (!validador.ValidarAngulo(
                txtNumAngulo.Text,
                out angulo,
                out mensaje))
            {
                MessageBox.Show(
                    mensaje,
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            RotarAeronave(angulo);
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            double x, y;
            string mensaje;

            if (!validador.ValidarCoordenadas(
                txtNumPosX.Text,
                txtNumPosY.Text,
                out x,
                out y,
                out mensaje))
            {
                MessageBox.Show(
                    mensaje,
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Crear la aeronave con la posición y orientación indicadas.
            aeronave = new Aeronave(x, y);
            aeronave.AnguloActual = (double)txtNumAngulo.Value;
            gestorRecorrido.LimpiarRecorrido();

            gestorRecorrido.RegistrarPosicion(
                aeronave.PosicionActual);

            vectorDesplazamiento = null;

            ActualizarDibujoAeronave();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            aeronave = new Aeronave(0, 0);

            gestorRecorrido.LimpiarRecorrido();

            gestorRecorrido.RegistrarPosicion(
                aeronave.PosicionActual);

            vectorDesplazamiento = null;
            txtNumPosX.Value = 0;
            txtNumPosY.Value = 0;
            txtNumAngulo.Value = 0;
            txtNumDesplX.Value = 0;
            txtNumDesplY.Value = 0;

            ActualizarDibujoAeronave();
        }
    }
}
