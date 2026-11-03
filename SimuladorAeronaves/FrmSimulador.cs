
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

namespace SimuladorAeronaves
{
    public partial class FrmSimulador : Form
    {
        private PlanoCartesiano plano = new PlanoCartesiano();
        private DibujoAeronave dibujoAeronave = new DibujoAeronave();
        private PointF[] verticesAeronave = null;

        public FrmSimulador()
        {
            InitializeComponent();
        }

        public void MostrarAeronave(PointF[] vertices)
        {
            // Guardamos los puntos de la aeronave
            verticesAeronave = vertices;

            // Actualizamos el dibujo del panel
            pnlDibujo.Invalidate();
        }

        private void pnlDibujo_Paint(object sender, PaintEventArgs e)
        {
            // Dibujamos el plano cartesiano
            plano.Dibujar(e.Graphics, pnlDibujo.Width, pnlDibujo.Height);

            // Dibujamos la aeronave si tenemos sus vertices
            if (verticesAeronave != null)
            {
                dibujoAeronave.Dibujar(e.Graphics, verticesAeronave,
                    pnlDibujo.Width, pnlDibujo.Height, 0.5f);
            }
        }
    }
}
