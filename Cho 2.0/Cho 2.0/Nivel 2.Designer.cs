namespace Cho_2._0
{
    partial class Nivel_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nivel_2));
            this.MonstruoButton = new System.Windows.Forms.Button();
            this.MonstruoBox = new System.Windows.Forms.PictureBox();
            this.CriaturaBox = new System.Windows.Forms.PictureBox();
            this.Pierdes = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comenzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarLv2 = new System.Windows.Forms.ProgressBar();
            this.Contadores = new System.Windows.Forms.Timer(this.components);
            this.Comida = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.MensajeInicio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MonstruoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriaturaBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MonstruoButton
            // 
            this.MonstruoButton.Location = new System.Drawing.Point(311, 33);
            this.MonstruoButton.Name = "MonstruoButton";
            this.MonstruoButton.Size = new System.Drawing.Size(97, 72);
            this.MonstruoButton.TabIndex = 0;
            this.MonstruoButton.UseVisualStyleBackColor = true;
            this.MonstruoButton.Visible = false;
            // 
            // MonstruoBox
            // 
            this.MonstruoBox.BackColor = System.Drawing.Color.Transparent;
            this.MonstruoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MonstruoBox.Image = global::Cho_2._0.Properties.Resources.MonstruoCho11;
            this.MonstruoBox.Location = new System.Drawing.Point(311, 33);
            this.MonstruoBox.Name = "MonstruoBox";
            this.MonstruoBox.Size = new System.Drawing.Size(97, 72);
            this.MonstruoBox.TabIndex = 1;
            this.MonstruoBox.TabStop = false;
            this.MonstruoBox.Click += new System.EventHandler(this.MonstruoBox_Click);
            // 
            // CriaturaBox
            // 
            this.CriaturaBox.BackColor = System.Drawing.Color.Transparent;
            this.CriaturaBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CriaturaBox.Image = global::Cho_2._0.Properties.Resources.CriaturaPoro1;
            this.CriaturaBox.Location = new System.Drawing.Point(500, 243);
            this.CriaturaBox.Name = "CriaturaBox";
            this.CriaturaBox.Size = new System.Drawing.Size(50, 46);
            this.CriaturaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CriaturaBox.TabIndex = 2;
            this.CriaturaBox.TabStop = false;
            this.CriaturaBox.Visible = false;
            // 
            // Pierdes
            // 
            this.Pierdes.Tick += new System.EventHandler(this.Pierdes_Tick);
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
            this.menuStrip1.TabIndex = 8;
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
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click_1);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // BarLv2
            // 
            this.BarLv2.Location = new System.Drawing.Point(942, 195);
            this.BarLv2.Name = "BarLv2";
            this.BarLv2.Size = new System.Drawing.Size(129, 23);
            this.BarLv2.TabIndex = 9;
            // 
            // Contadores
            // 
            this.Contadores.Interval = 1000;
            this.Contadores.Tick += new System.EventHandler(this.Contadores_Tick);
            // 
            // Comida
            // 
            this.Comida.AutoSize = true;
            this.Comida.BackColor = System.Drawing.Color.Transparent;
            this.Comida.Location = new System.Drawing.Point(939, 169);
            this.Comida.Name = "Comida";
            this.Comida.Size = new System.Drawing.Size(106, 13);
            this.Comida.TabIndex = 10;
            this.Comida.Text = "Criaturas Comidas : 0";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Location = new System.Drawing.Point(939, 138);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(57, 13);
            this.Time.TabIndex = 11;
            this.Time.Text = "Tiempo : 0";
            // 
            // MensajeInicio
            // 
            this.MensajeInicio.AutoSize = true;
            this.MensajeInicio.BackColor = System.Drawing.Color.Transparent;
            this.MensajeInicio.Font = new System.Drawing.Font("Snap ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensajeInicio.ForeColor = System.Drawing.Color.Black;
            this.MensajeInicio.Location = new System.Drawing.Point(91, 195);
            this.MensajeInicio.Name = "MensajeInicio";
            this.MensajeInicio.Size = new System.Drawing.Size(709, 27);
            this.MensajeInicio.TabIndex = 16;
            this.MensajeInicio.Text = "PRESIONA BARRA ESPACIADORA PARA COMENZAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cho_2._0.Properties.Resources.Cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(1063, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Nivel_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cho_2._0.Properties.Resources.FondoPrincipal;
            this.ClientSize = new System.Drawing.Size(1116, 539);
            this.ControlBox = false;
            this.Controls.Add(this.MensajeInicio);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Comida);
            this.Controls.Add(this.BarLv2);
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
            this.Name = "Nivel_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nivel_2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Nivel_2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MonstruoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriaturaBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MonstruoButton;
        private System.Windows.Forms.PictureBox MonstruoBox;
        private System.Windows.Forms.PictureBox CriaturaBox;
        private System.Windows.Forms.Timer Pierdes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comenzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ProgressBar BarLv2;
        private System.Windows.Forms.Timer Contadores;
        private System.Windows.Forms.Label Comida;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label MensajeInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}