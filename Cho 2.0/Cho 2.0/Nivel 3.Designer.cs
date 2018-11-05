namespace Cho_2._0
{
    partial class Nivel_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nivel_3));
            this.MonstruoBox = new System.Windows.Forms.PictureBox();
            this.CriaturaBox = new System.Windows.Forms.PictureBox();
            this.BarLv3 = new System.Windows.Forms.ProgressBar();
            this.Comida = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.MensajeInicio = new System.Windows.Forms.Label();
            this.PierdesLv3 = new System.Windows.Forms.Timer(this.components);
            this.MonstruoButton = new System.Windows.Forms.Button();
            this.ContadoresLv3 = new System.Windows.Forms.Timer(this.components);
            this.Centinela = new System.Windows.Forms.PictureBox();
            this.Pierdes2Lv3 = new System.Windows.Forms.Timer(this.components);
            this.TiempoPoder = new System.Windows.Forms.Timer(this.components);
            this.Duracion = new System.Windows.Forms.Label();
            this.CentinelaAparicion = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaestroDeCartas = new System.Windows.Forms.PictureBox();
            this.comenzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.MonstruoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriaturaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Centinela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaestroDeCartas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MonstruoBox
            // 
            this.MonstruoBox.BackColor = System.Drawing.Color.Transparent;
            this.MonstruoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MonstruoBox.Image = global::Cho_2._0.Properties.Resources.MonstruoCho11;
            this.MonstruoBox.Location = new System.Drawing.Point(9, 37);
            this.MonstruoBox.Name = "MonstruoBox";
            this.MonstruoBox.Size = new System.Drawing.Size(54, 38);
            this.MonstruoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MonstruoBox.TabIndex = 2;
            this.MonstruoBox.TabStop = false;
            // 
            // CriaturaBox
            // 
            this.CriaturaBox.BackColor = System.Drawing.Color.Transparent;
            this.CriaturaBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CriaturaBox.Image = global::Cho_2._0.Properties.Resources.CriaturaPoro1;
            this.CriaturaBox.Location = new System.Drawing.Point(481, 289);
            this.CriaturaBox.Name = "CriaturaBox";
            this.CriaturaBox.Size = new System.Drawing.Size(39, 34);
            this.CriaturaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CriaturaBox.TabIndex = 3;
            this.CriaturaBox.TabStop = false;
            this.CriaturaBox.Visible = false;
            // 
            // BarLv3
            // 
            this.BarLv3.Location = new System.Drawing.Point(942, 239);
            this.BarLv3.Name = "BarLv3";
            this.BarLv3.Size = new System.Drawing.Size(100, 23);
            this.BarLv3.TabIndex = 4;
            // 
            // Comida
            // 
            this.Comida.AutoSize = true;
            this.Comida.BackColor = System.Drawing.Color.Transparent;
            this.Comida.Location = new System.Drawing.Point(939, 208);
            this.Comida.Name = "Comida";
            this.Comida.Size = new System.Drawing.Size(91, 13);
            this.Comida.TabIndex = 11;
            this.Comida.Text = "Criaturas Comidas";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Location = new System.Drawing.Point(939, 179);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(69, 13);
            this.Time.TabIndex = 12;
            this.Time.Text = "Tiempo : 200";
            // 
            // MensajeInicio
            // 
            this.MensajeInicio.AutoSize = true;
            this.MensajeInicio.BackColor = System.Drawing.Color.Transparent;
            this.MensajeInicio.Font = new System.Drawing.Font("Snap ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensajeInicio.ForeColor = System.Drawing.Color.Black;
            this.MensajeInicio.Location = new System.Drawing.Point(76, 165);
            this.MensajeInicio.Name = "MensajeInicio";
            this.MensajeInicio.Size = new System.Drawing.Size(709, 27);
            this.MensajeInicio.TabIndex = 17;
            this.MensajeInicio.Text = "PRESIONA BARRA ESPACIADORA PARA COMENZAR";
            // 
            // PierdesLv3
            // 
            this.PierdesLv3.Tick += new System.EventHandler(this.PierdesLv3_Tick);
            // 
            // MonstruoButton
            // 
            this.MonstruoButton.Location = new System.Drawing.Point(9, 37);
            this.MonstruoButton.Name = "MonstruoButton";
            this.MonstruoButton.Size = new System.Drawing.Size(54, 38);
            this.MonstruoButton.TabIndex = 19;
            this.MonstruoButton.UseVisualStyleBackColor = true;
            this.MonstruoButton.Visible = false;
            // 
            // ContadoresLv3
            // 
            this.ContadoresLv3.Interval = 1000;
            this.ContadoresLv3.Tick += new System.EventHandler(this.Contadores_Tick);
            // 
            // Centinela
            // 
            this.Centinela.BackColor = System.Drawing.Color.Transparent;
            this.Centinela.Image = global::Cho_2._0.Properties.Resources.Centinela;
            this.Centinela.Location = new System.Drawing.Point(942, 118);
            this.Centinela.Name = "Centinela";
            this.Centinela.Size = new System.Drawing.Size(42, 40);
            this.Centinela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Centinela.TabIndex = 20;
            this.Centinela.TabStop = false;
            // 
            // Pierdes2Lv3
            // 
            this.Pierdes2Lv3.Tick += new System.EventHandler(this.Pierdes2Lv3_Tick);
            // 
            // TiempoPoder
            // 
            this.TiempoPoder.Interval = 1000;
            this.TiempoPoder.Tick += new System.EventHandler(this.TiempoPoder_Tick);
            // 
            // Duracion
            // 
            this.Duracion.AutoSize = true;
            this.Duracion.BackColor = System.Drawing.Color.Transparent;
            this.Duracion.Location = new System.Drawing.Point(939, 289);
            this.Duracion.Name = "Duracion";
            this.Duracion.Size = new System.Drawing.Size(105, 13);
            this.Duracion.TabIndex = 21;
            this.Duracion.Text = "Duracion Efecto : 10";
            this.Duracion.Visible = false;
            // 
            // CentinelaAparicion
            // 
            this.CentinelaAparicion.Tick += new System.EventHandler(this.CentinelaAparicion_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cho_2._0.Properties.Resources.Cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(1063, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MaestroDeCartas
            // 
            this.MaestroDeCartas.BackColor = System.Drawing.Color.Transparent;
            this.MaestroDeCartas.Image = global::Cho_2._0.Properties.Resources.TFGif;
            this.MaestroDeCartas.Location = new System.Drawing.Point(1023, 118);
            this.MaestroDeCartas.Name = "MaestroDeCartas";
            this.MaestroDeCartas.Size = new System.Drawing.Size(45, 40);
            this.MaestroDeCartas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaestroDeCartas.TabIndex = 23;
            this.MaestroDeCartas.TabStop = false;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comenzarToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.reiniciarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Nivel_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cho_2._0.Properties.Resources.FondoLv3;
            this.ClientSize = new System.Drawing.Size(1116, 539);
            this.ControlBox = false;
            this.Controls.Add(this.MaestroDeCartas);
            this.Controls.Add(this.Duracion);
            this.Controls.Add(this.Centinela);
            this.Controls.Add(this.MensajeInicio);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Comida);
            this.Controls.Add(this.BarLv3);
            this.Controls.Add(this.CriaturaBox);
            this.Controls.Add(this.MonstruoBox);
            this.Controls.Add(this.MonstruoButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nivel_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nivel 3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Nivel_3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MonstruoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriaturaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Centinela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaestroDeCartas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MonstruoBox;
        private System.Windows.Forms.PictureBox CriaturaBox;
        private System.Windows.Forms.ProgressBar BarLv3;
        private System.Windows.Forms.Label Comida;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label MensajeInicio;
        private System.Windows.Forms.Timer PierdesLv3;
        private System.Windows.Forms.Button MonstruoButton;
        private System.Windows.Forms.Timer ContadoresLv3;
        private System.Windows.Forms.PictureBox Centinela;
        private System.Windows.Forms.Timer Pierdes2Lv3;
        private System.Windows.Forms.Timer TiempoPoder;
        private System.Windows.Forms.Label Duracion;
        private System.Windows.Forms.Timer CentinelaAparicion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox MaestroDeCartas;
        private System.Windows.Forms.ToolStripMenuItem comenzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}