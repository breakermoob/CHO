namespace Cho_2._0
{
    partial class Nivel_4
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MaestroDeCartas = new System.Windows.Forms.PictureBox();
            this.Duracion = new System.Windows.Forms.Label();
            this.Centinela = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Label();
            this.Comida = new System.Windows.Forms.Label();
            this.BarLv4 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comenzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MensajeInicio = new System.Windows.Forms.Label();
            this.CriaturaBox = new System.Windows.Forms.PictureBox();
            this.MonstruoBox = new System.Windows.Forms.PictureBox();
            this.MonstruoButton = new System.Windows.Forms.Button();
            this.PierdesLv4 = new System.Windows.Forms.Timer(this.components);
            this.ContadoresLv4 = new System.Windows.Forms.Timer(this.components);
            this.Pierdes2Lv4 = new System.Windows.Forms.Timer(this.components);
            this.TiempoPoder = new System.Windows.Forms.Timer(this.components);
            this.CentinelaAparicion = new System.Windows.Forms.Timer(this.components);
            this.botonSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MaestroDeCartas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Centinela)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CriaturaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonstruoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // MaestroDeCartas
            // 
            this.MaestroDeCartas.BackColor = System.Drawing.Color.Transparent;
            this.MaestroDeCartas.Image = global::Cho_2._0.Properties.Resources.TFGif;
            this.MaestroDeCartas.Location = new System.Drawing.Point(1025, 125);
            this.MaestroDeCartas.Name = "MaestroDeCartas";
            this.MaestroDeCartas.Size = new System.Drawing.Size(31, 32);
            this.MaestroDeCartas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaestroDeCartas.TabIndex = 29;
            this.MaestroDeCartas.TabStop = false;
            // 
            // Duracion
            // 
            this.Duracion.AutoSize = true;
            this.Duracion.BackColor = System.Drawing.Color.Transparent;
            this.Duracion.Location = new System.Drawing.Point(941, 296);
            this.Duracion.Name = "Duracion";
            this.Duracion.Size = new System.Drawing.Size(105, 13);
            this.Duracion.TabIndex = 28;
            this.Duracion.Text = "Duracion Efecto : 10";
            this.Duracion.Visible = false;
            // 
            // Centinela
            // 
            this.Centinela.BackColor = System.Drawing.Color.Transparent;
            this.Centinela.Image = global::Cho_2._0.Properties.Resources.Centinela;
            this.Centinela.Location = new System.Drawing.Point(944, 125);
            this.Centinela.Name = "Centinela";
            this.Centinela.Size = new System.Drawing.Size(35, 32);
            this.Centinela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Centinela.TabIndex = 27;
            this.Centinela.TabStop = false;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Location = new System.Drawing.Point(941, 186);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(69, 13);
            this.Time.TabIndex = 26;
            this.Time.Text = "Tiempo : 300";
            // 
            // Comida
            // 
            this.Comida.AutoSize = true;
            this.Comida.BackColor = System.Drawing.Color.Transparent;
            this.Comida.Location = new System.Drawing.Point(941, 215);
            this.Comida.Name = "Comida";
            this.Comida.Size = new System.Drawing.Size(91, 13);
            this.Comida.TabIndex = 25;
            this.Comida.Text = "Criaturas Comidas";
            // 
            // BarLv4
            // 
            this.BarLv4.Location = new System.Drawing.Point(944, 246);
            this.BarLv4.Name = "BarLv4";
            this.BarLv4.Size = new System.Drawing.Size(100, 23);
            this.BarLv4.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comenzarToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.reiniciarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comenzarToolStripMenuItem
            // 
            this.comenzarToolStripMenuItem.Name = "comenzarToolStripMenuItem";
            this.comenzarToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.comenzarToolStripMenuItem.Text = "Comenzar";
            this.comenzarToolStripMenuItem.Click += new System.EventHandler(this.comenzarToolStripMenuItem_Click);
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.pausarToolStripMenuItem.Text = "Pausar";
            this.pausarToolStripMenuItem.Click += new System.EventHandler(this.pausarToolStripMenuItem_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MensajeInicio
            // 
            this.MensajeInicio.AutoSize = true;
            this.MensajeInicio.BackColor = System.Drawing.Color.Transparent;
            this.MensajeInicio.Font = new System.Drawing.Font("Snap ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensajeInicio.ForeColor = System.Drawing.Color.Black;
            this.MensajeInicio.Location = new System.Drawing.Point(84, 186);
            this.MensajeInicio.Name = "MensajeInicio";
            this.MensajeInicio.Size = new System.Drawing.Size(709, 27);
            this.MensajeInicio.TabIndex = 33;
            this.MensajeInicio.Text = "PRESIONA BARRA ESPACIADORA PARA COMENZAR";
            // 
            // CriaturaBox
            // 
            this.CriaturaBox.BackColor = System.Drawing.Color.Transparent;
            this.CriaturaBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CriaturaBox.Image = global::Cho_2._0.Properties.Resources.CriaturaPoro1;
            this.CriaturaBox.Location = new System.Drawing.Point(443, 270);
            this.CriaturaBox.Name = "CriaturaBox";
            this.CriaturaBox.Size = new System.Drawing.Size(30, 27);
            this.CriaturaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CriaturaBox.TabIndex = 32;
            this.CriaturaBox.TabStop = false;
            this.CriaturaBox.Visible = false;
            // 
            // MonstruoBox
            // 
            this.MonstruoBox.BackColor = System.Drawing.Color.Transparent;
            this.MonstruoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MonstruoBox.Image = global::Cho_2._0.Properties.Resources.MonstruoCho11;
            this.MonstruoBox.Location = new System.Drawing.Point(0, 516);
            this.MonstruoBox.Name = "MonstruoBox";
            this.MonstruoBox.Size = new System.Drawing.Size(30, 19);
            this.MonstruoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MonstruoBox.TabIndex = 31;
            this.MonstruoBox.TabStop = false;
            // 
            // MonstruoButton
            // 
            this.MonstruoButton.Location = new System.Drawing.Point(0, 516);
            this.MonstruoButton.Name = "MonstruoButton";
            this.MonstruoButton.Size = new System.Drawing.Size(30, 19);
            this.MonstruoButton.TabIndex = 34;
            this.MonstruoButton.UseVisualStyleBackColor = true;
            this.MonstruoButton.Visible = false;
            // 
            // PierdesLv4
            // 
            this.PierdesLv4.Tick += new System.EventHandler(this.PierdesLv4_Tick);
            // 
            // ContadoresLv4
            // 
            this.ContadoresLv4.Interval = 1000;
            this.ContadoresLv4.Tick += new System.EventHandler(this.ContadoresLv4_Tick);
            // 
            // Pierdes2Lv4
            // 
            this.Pierdes2Lv4.Tick += new System.EventHandler(this.Pierdes2Lv4_Tick);
            // 
            // TiempoPoder
            // 
            this.TiempoPoder.Interval = 1000;
            this.TiempoPoder.Tick += new System.EventHandler(this.TiempoPoder_Tick);
            // 
            // CentinelaAparicion
            // 
            this.CentinelaAparicion.Tick += new System.EventHandler(this.CentinelaAparicion_Tick);
            // 
            // botonSalir
            // 
            this.botonSalir.Image = global::Cho_2._0.Properties.Resources.Cerrar;
            this.botonSalir.Location = new System.Drawing.Point(1062, 0);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(53, 24);
            this.botonSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonSalir.TabIndex = 35;
            this.botonSalir.TabStop = false;
            this.botonSalir.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Nivel_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cho_2._0.Properties.Resources.FondoLv41;
            this.ClientSize = new System.Drawing.Size(1115, 537);
            this.ControlBox = false;
            this.Controls.Add(this.MensajeInicio);
            this.Controls.Add(this.CriaturaBox);
            this.Controls.Add(this.MonstruoBox);
            this.Controls.Add(this.MonstruoButton);
            this.Controls.Add(this.MaestroDeCartas);
            this.Controls.Add(this.Duracion);
            this.Controls.Add(this.Centinela);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Comida);
            this.Controls.Add(this.BarLv4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.botonSalir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Nivel_4";
            this.Text = "Nivel 4";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Nivel_4_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MaestroDeCartas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Centinela)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CriaturaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonstruoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MaestroDeCartas;
        private System.Windows.Forms.Label Duracion;
        private System.Windows.Forms.PictureBox Centinela;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Comida;
        private System.Windows.Forms.ProgressBar BarLv4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comenzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label MensajeInicio;
        private System.Windows.Forms.PictureBox CriaturaBox;
        private System.Windows.Forms.PictureBox MonstruoBox;
        private System.Windows.Forms.Button MonstruoButton;
        private System.Windows.Forms.Timer PierdesLv4;
        private System.Windows.Forms.Timer ContadoresLv4;
        private System.Windows.Forms.Timer Pierdes2Lv4;
        private System.Windows.Forms.Timer TiempoPoder;
        private System.Windows.Forms.Timer CentinelaAparicion;
        private System.Windows.Forms.PictureBox botonSalir;
    }
}