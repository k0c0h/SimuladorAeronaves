
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
        private ValidadorDatos validador = new ValidadorDatos();
        private List<Aeronave> aeronaves = new List<Aeronave>();
        private Dictionary<Aeronave, GestorRecorrido> recorridos =
            new Dictionary<Aeronave, GestorRecorrido>();
        private Dictionary<Aeronave, PointF[]> vectoresDesplazamiento =
            new Dictionary<Aeronave, PointF[]>();
        private Dictionary<Aeronave, Punto2D> destinosManuales =
            new Dictionary<Aeronave, Punto2D>();
        private Dictionary<Aeronave, PointF> direccionesManuales =
            new Dictionary<Aeronave, PointF>();
        private HashSet<Aeronave> movimientosManualesFinalizados =
            new HashSet<Aeronave>();
        private Aeronave aeronaveSeleccionada;

        public FrmSimulador()
        {
            InitializeComponent();

            pnlDibujo.Resize += pnlDibujo_Resize;
            cmbCantidadAeronaves.Items.AddRange(
                new object[] { 1, 2, 3, 4, 5 });
            cmbCantidadAeronaves.SelectedIndexChanged +=
                cmbCantidadAeronaves_SelectedIndexChanged;
            cmbCantidadAeronaves.SelectedIndex = 4;

            InicializarAeronaves(5);
        }

        public void MostrarAeronave(PointF[] vertices)
        {
            if (aeronaveSeleccionada == null || vertices == null)
                return;

            pnlDibujo.Invalidate();
        }

        private void InicializarAeronaves(int cantidad)
        {
            aeronaves.Clear();
            recorridos.Clear();
            vectoresDesplazamiento.Clear();
            destinosManuales.Clear();
            direccionesManuales.Clear();
            movimientosManualesFinalizados.Clear();

            double[,] posiciones =
            {
                { -350, 250 },
                { 350, 250 },
                { -350, -150 },
                { 350, -150 },
                { 0, 0 }
            };

            for (int i = 0; i < cantidad; i++)
            {
                Aeronave nueva = new Aeronave(
                    posiciones[i, 0],
                    posiciones[i, 1]);

                aeronaves.Add(nueva);

                GestorRecorrido recorrido = new GestorRecorrido();
                recorrido.RegistrarPosicion(nueva.PosicionActual);
                recorridos.Add(nueva, recorrido);
            }

            aeronaveSeleccionada = aeronaves[aeronaves.Count - 1];
            ActualizarControlesAeronaveSeleccionada();
            pnlDibujo.Invalidate();
        }

        private void cmbCantidadAeronaves_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbCantidadAeronaves.SelectedItem == null)
                return;

            InicializarAeronaves((int)cmbCantidadAeronaves.SelectedItem);
        }

        private void pnlDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            float escala = ObtenerEscala();
            float centroX = pnlDibujo.Width / 2f;
            float centroY = pnlDibujo.Height / 2f;
            Aeronave masCercana = null;
            double distanciaMinima = 45;

            foreach (Aeronave aeronave in aeronaves)
            {
                float pantallaX = centroX +
                    (float)aeronave.PosicionActual.X * escala;
                float pantallaY = centroY -
                    (float)aeronave.PosicionActual.Y * escala;

                double distancia = Math.Sqrt(
                    Math.Pow(e.X - pantallaX, 2) +
                    Math.Pow(e.Y - pantallaY, 2));

                if (distancia < distanciaMinima)
                {
                    distanciaMinima = distancia;
                    masCercana = aeronave;
                }
            }

            if (masCercana != null)
            {
                aeronaveSeleccionada = masCercana;
                ActualizarControlesAeronaveSeleccionada();
                pnlDibujo.Invalidate();
            }
        }

        private float ObtenerEscala()
        {
            const float margen = 35f;
            const float limiteX = 375f;
            const float limiteY = 275f;

            float escalaX = (pnlDibujo.Width / 2f - margen) / limiteX;
            float escalaY = (pnlDibujo.Height / 2f - margen) / limiteY;

            return Math.Max(0.35f, Math.Min(1.0f, Math.Min(escalaX, escalaY)));
        }

        private void ActualizarControlesAeronaveSeleccionada()
        {
            if (aeronaveSeleccionada == null)
                return;

            txtNumPosX.Value = LimitarValor(
                aeronaveSeleccionada.PosicionActual.X,
                txtNumPosX.Minimum,
                txtNumPosX.Maximum);
            txtNumPosY.Value = LimitarValor(
                aeronaveSeleccionada.PosicionActual.Y,
                txtNumPosY.Minimum,
                txtNumPosY.Maximum);
            txtNumAngulo.Value = LimitarValor(
                aeronaveSeleccionada.AnguloActual,
                txtNumAngulo.Minimum,
                txtNumAngulo.Maximum);

            lblAeronaveSeleccionada.Text =
                "SELECCIONADA: A" + (aeronaves.IndexOf(aeronaveSeleccionada) + 1);
        }

        private decimal LimitarValor(double valor, decimal minimo, decimal maximo)
        {
            if (valor < (double)minimo)
                return minimo;
            if (valor > (double)maximo)
                return maximo;
            return (decimal)valor;
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

            float escala = ObtenerEscala();
            float centroX = pnlDibujo.Width / 2f;
            float centroY = pnlDibujo.Height / 2f;

            foreach (Aeronave aeronave in aeronaves)
            {
                bool seleccionada = aeronave == aeronaveSeleccionada;
                DibujarRecorrido(g, recorridos[aeronave], centroX, centroY, escala);

                if (vectoresDesplazamiento.ContainsKey(aeronave))
                {
                    DibujarVector(
                        g,
                        vectoresDesplazamiento[aeronave],
                        centroX,
                        centroY,
                        escala);
                }

                List<Punto2D> vertices =
                    aeronave.ObtenerVerticesTransformados();
                PointF[] verticesPantalla = new PointF[vertices.Count];

                for (int i = 0; i < vertices.Count; i++)
                {
                    verticesPantalla[i] = new PointF(
                        (float)vertices[i].X,
                        (float)vertices[i].Y);
                }

                dibujoAeronave.Dibujar(
                    g,
                    verticesPantalla,
                    pnlDibujo.Width,
                    pnlDibujo.Height,
                    escala,
                    seleccionada);

                DibujarCoordenadasAeronave(
                    g,
                    aeronave,
                    centroX,
                    centroY,
                    escala,
                    seleccionada);
            }
        }

        private void DibujarRecorrido(
            Graphics g,
            GestorRecorrido gestor,
            float centroX,
            float centroY,
            float escala)
        {
            List<Punto2D> recorrido = gestor.ObtenerRecorrido();

            if (recorrido.Count < 2)
                return;

            using (Pen lapizRecorrido = new Pen(Color.OrangeRed, 2))
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

        private void DibujarVector(
            Graphics g,
            PointF[] vector,
            float centroX,
            float centroY,
            float escala)
        {
            if (vector == null || vector.Length != 2)
                return;

            PointF inicio = new PointF(
                centroX + vector[0].X * escala,
                centroY - vector[0].Y * escala);
            PointF fin = new PointF(
                centroX + vector[1].X * escala,
                centroY - vector[1].Y * escala);

            using (Pen lapizVector = new Pen(Color.Blue, 2))
            {
                lapizVector.EndCap =
                    System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                g.DrawLine(lapizVector, inicio, fin);
            }
        }

        private void DibujarCoordenadasAeronave(
            Graphics g,
            Aeronave aeronave,
            float centroX,
            float centroY,
            float escala,
            bool seleccionada)
        {
            if (aeronave == null || aeronave.PosicionActual == null)
                return;

            PointF puntoPosicion = new PointF(
                centroX + (float)aeronave.PosicionActual.X * escala,
                centroY - (float)aeronave.PosicionActual.Y * escala);

            Color colorPunto = seleccionada ? Color.Yellow : Color.LightGray;

            using (Brush pincelPunto = new SolidBrush(colorPunto))
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
                    "A{2}: ({0:0.##}, {1:0.##})",
                    aeronave.PosicionActual.X,
                    aeronave.PosicionActual.Y,
                    aeronaves.IndexOf(aeronave) + 1);

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

        private bool TrasladarAeronave(double dx, double dy)
        {
            if (aeronaveSeleccionada == null)
                return false;

            double posicionAnteriorX = aeronaveSeleccionada.PosicionActual.X;
            double posicionAnteriorY = aeronaveSeleccionada.PosicionActual.Y;
            double nuevaX = posicionAnteriorX + dx;
            double nuevaY = posicionAnteriorY + dy;

            aeronaveSeleccionada.PosicionActual = new Punto2D(nuevaX, nuevaY);

            recorridos[aeronaveSeleccionada].RegistrarPosicion(
                aeronaveSeleccionada.PosicionActual);

            vectoresDesplazamiento[aeronaveSeleccionada] = new PointF[]
            {
                new PointF((float)posicionAnteriorX, (float)posicionAnteriorY),
                new PointF((float)nuevaX, (float)nuevaY)
            };

            ActualizarControlesAeronaveSeleccionada();
            pnlDibujo.Invalidate();
            return true;
        }

        private bool RotarAeronave(double angulo)
        {
            if (aeronaveSeleccionada == null)
                return false;

            aeronaveSeleccionada.AnguloActual += angulo;

            ActualizarControlesAeronaveSeleccionada();
            pnlDibujo.Invalidate();
            return true;
        }

        private bool MoverManualmente(
            double direccionX,
            double direccionY,
            double velocidad)
        {
            if (aeronaveSeleccionada == null)
                return false;

            double longitud = Math.Sqrt(
                direccionX * direccionX + direccionY * direccionY);

            if (longitud == 0 || velocidad <= 0)
                return false;

            PointF direccion = new PointF(
                (float)direccionX,
                (float)direccionY);

            bool nuevaDireccion = !direccionesManuales.ContainsKey(aeronaveSeleccionada) ||
                direccionesManuales[aeronaveSeleccionada].X != direccion.X ||
                direccionesManuales[aeronaveSeleccionada].Y != direccion.Y;

            if (nuevaDireccion)
            {
                direccionesManuales[aeronaveSeleccionada] = direccion;
                destinosManuales[aeronaveSeleccionada] = new Punto2D(
                    aeronaveSeleccionada.PosicionActual.X + direccionX,
                    aeronaveSeleccionada.PosicionActual.Y + direccionY);
                movimientosManualesFinalizados.Remove(aeronaveSeleccionada);
            }

            if (movimientosManualesFinalizados.Contains(aeronaveSeleccionada))
                return false;

            Punto2D destino = destinosManuales[aeronaveSeleccionada];
            double diferenciaX = destino.X - aeronaveSeleccionada.PosicionActual.X;
            double diferenciaY = destino.Y - aeronaveSeleccionada.PosicionActual.Y;
            double distancia = Math.Sqrt(
                diferenciaX * diferenciaX + diferenciaY * diferenciaY);

            if (distancia == 0)
            {
                movimientosManualesFinalizados.Add(aeronaveSeleccionada);
                return false;
            }

            double paso = Math.Min(velocidad, distancia);
            double dx = diferenciaX / distancia * paso;
            double dy = diferenciaY / distancia * paso;

            bool trasladada = TrasladarAeronave(dx, dy);

            if (paso >= distancia)
                movimientosManualesFinalizados.Add(aeronaveSeleccionada);

            return trasladada;
        }

        private void AplicarPosicionSeleccionada(double x, double y)
        {
            if (aeronaveSeleccionada == null)
                return;

            aeronaveSeleccionada.PosicionActual = new Punto2D(x, y);
            recorridos[aeronaveSeleccionada].LimpiarRecorrido();
            recorridos[aeronaveSeleccionada].RegistrarPosicion(
                aeronaveSeleccionada.PosicionActual);
            vectoresDesplazamiento.Remove(aeronaveSeleccionada);
            destinosManuales.Remove(aeronaveSeleccionada);
            direccionesManuales.Remove(aeronaveSeleccionada);
            movimientosManualesFinalizados.Remove(aeronaveSeleccionada);
            ActualizarControlesAeronaveSeleccionada();
            pnlDibujo.Invalidate();
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
            destinosManuales.Remove(aeronaveSeleccionada);
            direccionesManuales.Remove(aeronaveSeleccionada);
            movimientosManualesFinalizados.Remove(aeronaveSeleccionada);
            pnlDibujo.Invalidate();
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
            pnlDibujo.Invalidate();
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

            AplicarPosicionSeleccionada(x, y);
            aeronaveSeleccionada.AnguloActual = (double)txtNumAngulo.Value;
            pnlDibujo.Invalidate();
        }

        private void btnMoverManual_Click(object sender, EventArgs e)
        {
            double direccionX, direccionY;
            double velocidad;
            string mensaje;

            if (!validador.ValidarDesplazamiento(
                txtNumDesplX.Text,
                txtNumDesplY.Text,
                out direccionX,
                out direccionY,
                out mensaje))
            {
                MessageBox.Show(
                    mensaje,
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!validador.IntentarLeerNumero(
                txtNumVelocidad.Text,
                out velocidad) || velocidad < 0)
            {
                mensaje = "Ingrese una velocidad válida mayor o igual a cero.";
                MessageBox.Show(
                    mensaje,
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MoverManualmente(direccionX, direccionY, velocidad);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            InicializarAeronaves((int)cmbCantidadAeronaves.SelectedItem);
            txtNumDesplX.Value = 0;
            txtNumDesplY.Value = 0;
            txtNumVelocidad.Value = 5;
        }

        private void pnlControles_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
