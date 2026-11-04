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
            this.lblAeronaveSeleccionada = new System.Windows.Forms.Label();
            this.lblCantidadAeronaves = new System.Windows.Forms.Label();
            this.cmbCantidadAeronaves = new System.Windows.Forms.ComboBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnMoverManual = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnRotar = new System.Windows.Forms.Button();
            this.btnTrasladar = new System.Windows.Forms.Button();
            this.lblAcciones = new System.Windows.Forms.Label();
            this.txtNumDesplY = new System.Windows.Forms.NumericUpDown();
            this.txtNumDesplX = new System.Windows.Forms.NumericUpDown();
            this.txtNumVelocidad = new System.Windows.Forms.NumericUpDown();
            this.lblDesplY = new System.Windows.Forms.Label();
            this.lblDesplX = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.txtNumAngulo = new System.Windows.Forms.NumericUpDown();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.txtNumPosY = new System.Windows.Forms.NumericUpDown();
            this.txtNumPosX = new System.Windows.Forms.NumericUpDown();
            this.lblPosY = new System.Windows.Forms.Label();
            this.lblPosX = new System.Windows.Forms.Label();
            this.lblControles = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDesplY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDesplX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumAngulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPosX)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDibujo
            // 
            this.pnlDibujo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDibujo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.pnlDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDibujo.Location = new System.Drawing.Point(382, 105);
            this.pnlDibujo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDibujo.Name = "pnlDibujo";
            this.pnlDibujo.Size = new System.Drawing.Size(993, 945);
            this.pnlDibujo.TabIndex = 0;
            this.pnlDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDibujo_Paint);
            this.pnlDibujo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseClick);
            // 
            // pnlControles
            // 
            this.pnlControles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(72)))));
            this.pnlControles.Controls.Add(this.lblAeronaveSeleccionada);
            this.pnlControles.Controls.Add(this.lblCantidadAeronaves);
            this.pnlControles.Controls.Add(this.cmbCantidadAeronaves);
            this.pnlControles.Controls.Add(this.btnReiniciar);
            this.pnlControles.Controls.Add(this.btnMoverManual);
            this.pnlControles.Controls.Add(this.btnDibujar);
            this.pnlControles.Controls.Add(this.btnRotar);
            this.pnlControles.Controls.Add(this.btnTrasladar);
            this.pnlControles.Controls.Add(this.lblAcciones);
            this.pnlControles.Controls.Add(this.txtNumDesplY);
            this.pnlControles.Controls.Add(this.txtNumDesplX);
            this.pnlControles.Controls.Add(this.txtNumVelocidad);
            this.pnlControles.Controls.Add(this.lblDesplY);
            this.pnlControles.Controls.Add(this.lblDesplX);
            this.pnlControles.Controls.Add(this.lblVelocidad);
            this.pnlControles.Controls.Add(this.txtNumAngulo);
            this.pnlControles.Controls.Add(this.lblAngulo);
            this.pnlControles.Controls.Add(this.txtNumPosY);
            this.pnlControles.Controls.Add(this.txtNumPosX);
            this.pnlControles.Controls.Add(this.lblPosY);
            this.pnlControles.Controls.Add(this.lblPosX);
            this.pnlControles.Controls.Add(this.lblControles);
            this.pnlControles.Location = new System.Drawing.Point(22, 106);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(326, 946);
            this.pnlControles.TabIndex = 1;
            this.pnlControles.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControles_Paint);
            // 
            // lblAeronaveSeleccionada
            // 
            this.lblAeronaveSeleccionada.AutoSize = true;
            this.lblAeronaveSeleccionada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeronaveSeleccionada.ForeColor = System.Drawing.Color.Yellow;
            this.lblAeronaveSeleccionada.Location = new System.Drawing.Point(17, 62);
            this.lblAeronaveSeleccionada.Name = "lblAeronaveSeleccionada";
            this.lblAeronaveSeleccionada.Size = new System.Drawing.Size(178, 25);
            this.lblAeronaveSeleccionada.TabIndex = 19;
            this.lblAeronaveSeleccionada.Text = "SELECCIONADA: A5";
            // 
            // lblCantidadAeronaves
            // 
            this.lblCantidadAeronaves.AutoSize = true;
            this.lblCantidadAeronaves.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAeronaves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblCantidadAeronaves.Location = new System.Drawing.Point(201, 57);
            this.lblCantidadAeronaves.Name = "lblCantidadAeronaves";
            this.lblCantidadAeronaves.Size = new System.Drawing.Size(99, 23);
            this.lblCantidadAeronaves.TabIndex = 20;
            this.lblCantidadAeronaves.Text = "CANTIDAD";
            // 
            // cmbCantidadAeronaves
            // 
            this.cmbCantidadAeronaves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidadAeronaves.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCantidadAeronaves.FormattingEnabled = true;
            this.cmbCantidadAeronaves.Location = new System.Drawing.Point(190, 90);
            this.cmbCantidadAeronaves.Name = "cmbCantidadAeronaves";
            this.cmbCantidadAeronaves.Size = new System.Drawing.Size(119, 33);
            this.cmbCantidadAeronaves.TabIndex = 21;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(105)))));
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(17, 842);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(287, 45);
            this.btnReiniciar.TabIndex = 15;
            this.btnReiniciar.Text = "REINICIAR";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnMoverManual
            // 
            this.btnMoverManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(92)))), ((int)(((byte)(190)))));
            this.btnMoverManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoverManual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverManual.ForeColor = System.Drawing.Color.White;
            this.btnMoverManual.Location = new System.Drawing.Point(17, 747);
            this.btnMoverManual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMoverManual.Name = "btnMoverManual";
            this.btnMoverManual.Size = new System.Drawing.Size(287, 40);
            this.btnMoverManual.TabIndex = 16;
            this.btnMoverManual.Text = "MOVER MANUALMENTE";
            this.btnMoverManual.UseVisualStyleBackColor = false;
            this.btnMoverManual.Click += new System.EventHandler(this.btnMoverManual_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(163)))), ((int)(((byte)(142)))));
            this.btnDibujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDibujar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.ForeColor = System.Drawing.Color.White;
            this.btnDibujar.Location = new System.Drawing.Point(17, 792);
            this.btnDibujar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(287, 45);
            this.btnDibujar.TabIndex = 14;
            this.btnDibujar.Text = "\tDIBUJAR AERONAVE";
            this.btnDibujar.UseVisualStyleBackColor = false;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnRotar
            // 
            this.btnRotar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.btnRotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotar.ForeColor = System.Drawing.Color.White;
            this.btnRotar.Location = new System.Drawing.Point(169, 697);
            this.btnRotar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(135, 50);
            this.btnRotar.TabIndex = 13;
            this.btnRotar.Text = "ROTAR";
            this.btnRotar.UseVisualStyleBackColor = false;
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // btnTrasladar
            // 
            this.btnTrasladar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(152)))), ((int)(((byte)(194)))));
            this.btnTrasladar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasladar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasladar.ForeColor = System.Drawing.Color.White;
            this.btnTrasladar.Location = new System.Drawing.Point(17, 697);
            this.btnTrasladar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTrasladar.Name = "btnTrasladar";
            this.btnTrasladar.Size = new System.Drawing.Size(135, 50);
            this.btnTrasladar.TabIndex = 12;
            this.btnTrasladar.Text = "TRASLADAR";
            this.btnTrasladar.UseVisualStyleBackColor = false;
            this.btnTrasladar.Click += new System.EventHandler(this.btnTrasladar_Click);
            // 
            // lblAcciones
            // 
            this.lblAcciones.AutoSize = true;
            this.lblAcciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            this.lblAcciones.Location = new System.Drawing.Point(17, 662);
            this.lblAcciones.Name = "lblAcciones";
            this.lblAcciones.Size = new System.Drawing.Size(131, 32);
            this.lblAcciones.TabIndex = 11;
            this.lblAcciones.Text = "ACCIONES";
            // 
            // txtNumDesplY
            // 
            this.txtNumDesplY.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDesplY.Location = new System.Drawing.Point(22, 591);
            this.txtNumDesplY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumDesplY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtNumDesplY.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.txtNumDesplY.Name = "txtNumDesplY";
            this.txtNumDesplY.Size = new System.Drawing.Size(287, 35);
            this.txtNumDesplY.TabIndex = 10;
            // 
            // txtNumDesplX
            // 
            this.txtNumDesplX.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDesplX.Location = new System.Drawing.Point(22, 526);
            this.txtNumDesplX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumDesplX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtNumDesplX.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.txtNumDesplX.Name = "txtNumDesplX";
            this.txtNumDesplX.Size = new System.Drawing.Size(287, 35);
            this.txtNumDesplX.TabIndex = 9;
            // 
            // txtNumVelocidad
            // 
            this.txtNumVelocidad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumVelocidad.Location = new System.Drawing.Point(22, 444);
            this.txtNumVelocidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumVelocidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtNumVelocidad.Name = "txtNumVelocidad";
            this.txtNumVelocidad.Size = new System.Drawing.Size(287, 35);
            this.txtNumVelocidad.TabIndex = 17;
            this.txtNumVelocidad.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblDesplY
            // 
            this.lblDesplY.AutoSize = true;
            this.lblDesplY.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesplY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblDesplY.Location = new System.Drawing.Point(22, 559);
            this.lblDesplY.Name = "lblDesplY";
            this.lblDesplY.Size = new System.Drawing.Size(210, 30);
            this.lblDesplY.TabIndex = 8;
            this.lblDesplY.Text = "\tDESPLAZAMIENTO Y";
            // 
            // lblDesplX
            // 
            this.lblDesplX.AutoSize = true;
            this.lblDesplX.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesplX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblDesplX.Location = new System.Drawing.Point(22, 492);
            this.lblDesplX.Name = "lblDesplX";
            this.lblDesplX.Size = new System.Drawing.Size(211, 30);
            this.lblDesplX.TabIndex = 7;
            this.lblDesplX.Text = "\tDESPLAZAMIENTO X";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblVelocidad.Location = new System.Drawing.Point(22, 412);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(125, 30);
            this.lblVelocidad.TabIndex = 18;
            this.lblVelocidad.Text = "VELOCIDAD";
            // 
            // txtNumAngulo
            // 
            this.txtNumAngulo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAngulo.Location = new System.Drawing.Point(22, 354);
            this.txtNumAngulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumAngulo.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.txtNumAngulo.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.txtNumAngulo.Name = "txtNumAngulo";
            this.txtNumAngulo.Size = new System.Drawing.Size(287, 35);
            this.txtNumAngulo.TabIndex = 6;
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblAngulo.Location = new System.Drawing.Point(22, 323);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(267, 30);
            this.lblAngulo.TabIndex = 5;
            this.lblAngulo.Text = "ÁNGULO DE ROTACIÓN (°)";
            // 
            // txtNumPosY
            // 
            this.txtNumPosY.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPosY.Location = new System.Drawing.Point(22, 266);
            this.txtNumPosY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumPosY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtNumPosY.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.txtNumPosY.Name = "txtNumPosY";
            this.txtNumPosY.Size = new System.Drawing.Size(287, 35);
            this.txtNumPosY.TabIndex = 4;
            // 
            // txtNumPosX
            // 
            this.txtNumPosX.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPosX.Location = new System.Drawing.Point(17, 173);
            this.txtNumPosX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumPosX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtNumPosX.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.txtNumPosX.Name = "txtNumPosX";
            this.txtNumPosX.Size = new System.Drawing.Size(287, 35);
            this.txtNumPosX.TabIndex = 3;
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.BackColor = System.Drawing.Color.Transparent;
            this.lblPosY.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblPosY.Location = new System.Drawing.Point(22, 235);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(127, 30);
            this.lblPosY.TabIndex = 2;
            this.lblPosY.Text = "POSICIÓN Y";
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblPosX.Location = new System.Drawing.Point(17, 142);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(128, 30);
            this.lblPosX.TabIndex = 1;
            this.lblPosX.Text = "POSICIÓN X";
            // 
            // lblControles
            // 
            this.lblControles.AutoSize = true;
            this.lblControles.BackColor = System.Drawing.Color.Transparent;
            this.lblControles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            this.lblControles.Location = new System.Drawing.Point(28, 13);
            this.lblControles.Name = "lblControles";
            this.lblControles.Size = new System.Drawing.Size(272, 32);
            this.lblControles.TabIndex = 0;
            this.lblControles.Text = "\tCONTROLES DE VUELO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(22, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(630, 54);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "\tSIMULADOR DE AERONAVES 2D";
            // 
            // FrmSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1389, 1050);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.pnlDibujo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FrmSimulador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Aeronaves 2D";
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDesplY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDesplX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumAngulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPosX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDibujo;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label lblAeronaveSeleccionada;
        private System.Windows.Forms.Label lblCantidadAeronaves;
        private System.Windows.Forms.ComboBox cmbCantidadAeronaves;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblControles;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.NumericUpDown txtNumPosY;
        private System.Windows.Forms.NumericUpDown txtNumPosX;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.NumericUpDown txtNumAngulo;
        private System.Windows.Forms.Label lblDesplX;
        private System.Windows.Forms.Label lblDesplY;
        private System.Windows.Forms.NumericUpDown txtNumDesplY;
        private System.Windows.Forms.NumericUpDown txtNumDesplX;
        private System.Windows.Forms.Label lblAcciones;
        private System.Windows.Forms.Button btnRotar;
        private System.Windows.Forms.Button btnTrasladar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnMoverManual;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.NumericUpDown txtNumVelocidad;
        private System.Windows.Forms.Label lblVelocidad;
    }
}