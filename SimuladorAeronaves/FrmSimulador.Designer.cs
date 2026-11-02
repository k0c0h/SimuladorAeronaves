namespace SimuladorAeronaves
{
    partial class FrmSimulador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDibujo = new System.Windows.Forms.Panel();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblControles = new System.Windows.Forms.Label();
            this.lblPosX = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.numPosX = new System.Windows.Forms.NumericUpDown();
            this.numPosY = new System.Windows.Forms.NumericUpDown();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.numAngulo = new System.Windows.Forms.NumericUpDown();
            this.lblDesplX = new System.Windows.Forms.Label();
            this.lblDesplY = new System.Windows.Forms.Label();
            this.numDesplX = new System.Windows.Forms.NumericUpDown();
            this.numDesplY = new System.Windows.Forms.NumericUpDown();
            this.lblAcciones = new System.Windows.Forms.Label();
            this.btnTrasladar = new System.Windows.Forms.Button();
            this.btnRotar = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesplX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesplY)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDibujo
            // 
            this.pnlDibujo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDibujo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.pnlDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDibujo.Location = new System.Drawing.Point(340, 84);
            this.pnlDibujo.Name = "pnlDibujo";
            this.pnlDibujo.Size = new System.Drawing.Size(830, 620);
            this.pnlDibujo.TabIndex = 0;
            this.pnlDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDibujo_Paint);
            // 
            // pnlControles
            // 
            this.pnlControles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(72)))));
            this.pnlControles.Controls.Add(this.btnReiniciar);
            this.pnlControles.Controls.Add(this.btnDibujar);
            this.pnlControles.Controls.Add(this.btnRotar);
            this.pnlControles.Controls.Add(this.btnTrasladar);
            this.pnlControles.Controls.Add(this.lblAcciones);
            this.pnlControles.Controls.Add(this.numDesplY);
            this.pnlControles.Controls.Add(this.numDesplX);
            this.pnlControles.Controls.Add(this.lblDesplY);
            this.pnlControles.Controls.Add(this.lblDesplX);
            this.pnlControles.Controls.Add(this.numAngulo);
            this.pnlControles.Controls.Add(this.lblAngulo);
            this.pnlControles.Controls.Add(this.numPosY);
            this.pnlControles.Controls.Add(this.numPosX);
            this.pnlControles.Controls.Add(this.lblPosY);
            this.pnlControles.Controls.Add(this.lblPosX);
            this.pnlControles.Controls.Add(this.lblControles);
            this.pnlControles.Location = new System.Drawing.Point(20, 85);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(290, 620);
            this.pnlControles.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(537, 46);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "\tSIMULADOR DE AERONAVES 2D";
            // 
            // lblControles
            // 
            this.lblControles.AutoSize = true;
            this.lblControles.BackColor = System.Drawing.Color.Transparent;
            this.lblControles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            this.lblControles.Location = new System.Drawing.Point(15, 20);
            this.lblControles.Name = "lblControles";
            this.lblControles.Size = new System.Drawing.Size(228, 28);
            this.lblControles.TabIndex = 0;
            this.lblControles.Text = "\tCONTROLES DE VUELO";
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblPosX.Location = new System.Drawing.Point(15, 75);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(105, 23);
            this.lblPosX.TabIndex = 1;
            this.lblPosX.Text = "POSICIÓN X";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.BackColor = System.Drawing.Color.Transparent;
            this.lblPosY.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblPosY.Location = new System.Drawing.Point(15, 145);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(104, 23);
            this.lblPosY.TabIndex = 2;
            this.lblPosY.Text = "POSICIÓN Y";
            // 
            // numPosX
            // 
            this.numPosX.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPosX.Location = new System.Drawing.Point(15, 100);
            this.numPosX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPosX.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numPosX.Name = "numPosX";
            this.numPosX.Size = new System.Drawing.Size(255, 30);
            this.numPosX.TabIndex = 3;
            // 
            // numPosY
            // 
            this.numPosY.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPosY.Location = new System.Drawing.Point(15, 170);
            this.numPosY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPosY.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numPosY.Name = "numPosY";
            this.numPosY.Size = new System.Drawing.Size(255, 30);
            this.numPosY.TabIndex = 4;
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblAngulo.Location = new System.Drawing.Point(15, 215);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(216, 23);
            this.lblAngulo.TabIndex = 5;
            this.lblAngulo.Text = "ÁNGULO DE ROTACIÓN (°)";
            // 
            // numAngulo
            // 
            this.numAngulo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAngulo.Location = new System.Drawing.Point(15, 240);
            this.numAngulo.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numAngulo.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numAngulo.Name = "numAngulo";
            this.numAngulo.Size = new System.Drawing.Size(255, 30);
            this.numAngulo.TabIndex = 6;
            // 
            // lblDesplX
            // 
            this.lblDesplX.AutoSize = true;
            this.lblDesplX.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesplX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblDesplX.Location = new System.Drawing.Point(15, 290);
            this.lblDesplX.Name = "lblDesplX";
            this.lblDesplX.Size = new System.Drawing.Size(170, 23);
            this.lblDesplX.TabIndex = 7;
            this.lblDesplX.Text = "\tDESPLAZAMIENTO X";
            // 
            // lblDesplY
            // 
            this.lblDesplY.AutoSize = true;
            this.lblDesplY.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesplY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblDesplY.Location = new System.Drawing.Point(15, 360);
            this.lblDesplY.Name = "lblDesplY";
            this.lblDesplY.Size = new System.Drawing.Size(169, 23);
            this.lblDesplY.TabIndex = 8;
            this.lblDesplY.Text = "\tDESPLAZAMIENTO Y";
            // 
            // numDesplX
            // 
            this.numDesplX.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDesplX.Location = new System.Drawing.Point(15, 315);
            this.numDesplX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDesplX.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numDesplX.Name = "numDesplX";
            this.numDesplX.Size = new System.Drawing.Size(255, 30);
            this.numDesplX.TabIndex = 9;
            // 
            // numDesplY
            // 
            this.numDesplY.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDesplY.Location = new System.Drawing.Point(15, 385);
            this.numDesplY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDesplY.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numDesplY.Name = "numDesplY";
            this.numDesplY.Size = new System.Drawing.Size(255, 30);
            this.numDesplY.TabIndex = 10;
            // 
            // lblAcciones
            // 
            this.lblAcciones.AutoSize = true;
            this.lblAcciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            this.lblAcciones.Location = new System.Drawing.Point(15, 430);
            this.lblAcciones.Name = "lblAcciones";
            this.lblAcciones.Size = new System.Drawing.Size(108, 28);
            this.lblAcciones.TabIndex = 11;
            this.lblAcciones.Text = "ACCIONES";
            // 
            // btnTrasladar
            // 
            this.btnTrasladar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(152)))), ((int)(((byte)(194)))));
            this.btnTrasladar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasladar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasladar.ForeColor = System.Drawing.Color.White;
            this.btnTrasladar.Location = new System.Drawing.Point(15, 465);
            this.btnTrasladar.Name = "btnTrasladar";
            this.btnTrasladar.Size = new System.Drawing.Size(120, 40);
            this.btnTrasladar.TabIndex = 12;
            this.btnTrasladar.Text = "TRASLADAR";
            this.btnTrasladar.UseVisualStyleBackColor = false;
            // 
            // btnRotar
            // 
            this.btnRotar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.btnRotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotar.ForeColor = System.Drawing.Color.White;
            this.btnRotar.Location = new System.Drawing.Point(150, 465);
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(120, 40);
            this.btnRotar.TabIndex = 13;
            this.btnRotar.Text = "ROTAR";
            this.btnRotar.UseVisualStyleBackColor = false;
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(163)))), ((int)(((byte)(142)))));
            this.btnDibujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDibujar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.ForeColor = System.Drawing.Color.White;
            this.btnDibujar.Location = new System.Drawing.Point(15, 520);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(255, 36);
            this.btnDibujar.TabIndex = 14;
            this.btnDibujar.Text = "\tDIBUJAR AERONAVE";
            this.btnDibujar.UseVisualStyleBackColor = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(105)))));
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(15, 565);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(255, 36);
            this.btnReiniciar.TabIndex = 15;
            this.btnReiniciar.Text = "REINICIAR";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            // 
            // FrmSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.pnlDibujo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSimulador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Aeronaves 2D";
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesplX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesplY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDibujo;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblControles;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.NumericUpDown numPosY;
        private System.Windows.Forms.NumericUpDown numPosX;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.NumericUpDown numAngulo;
        private System.Windows.Forms.Label lblDesplX;
        private System.Windows.Forms.Label lblDesplY;
        private System.Windows.Forms.NumericUpDown numDesplY;
        private System.Windows.Forms.NumericUpDown numDesplX;
        private System.Windows.Forms.Label lblAcciones;
        private System.Windows.Forms.Button btnRotar;
        private System.Windows.Forms.Button btnTrasladar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnDibujar;
    }
}