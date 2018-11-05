namespace Cho_2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MonstruoButton = new System.Windows.Forms.Button();
            this.MonstruoBox = new System.Windows.Forms.PictureBox();
            this.CriaturaBox = new System.Windows.Forms.PictureBox();
            this.BarLv1 = new System.Windows.Forms.ProgressBar();
            this.Tiempo = new System.Windows.Forms.Label();
            this.Contadores = new System.Windows.Forms.Timer(this.components);
            this.Comida = new System.Windows.Forms.Label();
            this.MensajeInicio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comenzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.MonstruoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriaturaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MonstruoButton
            // 
            this.MonstruoButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.MonstruoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MonstruoButton.BackColor = System.Drawing.Color.Transparent;
            this.MonstruoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MonstruoButton.Cursor = System.Windows.Forms.Cursors.No;
            this.MonstruoButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MonstruoButton.ForeColor = System.Drawing.Color.Transparent;
            this.MonstruoButton.Location = new System.Drawing.Point(68, 43);
            this.MonstruoButton.Name = "MonstruoButton";
            this.MonstruoButton.Size = new System.Drawing.Size(96, 74);
            this.MonstruoButton.TabIndex = 0;
            this.MonstruoButton.UseMnemonic = false;
            this.MonstruoButton.UseVisualStyleBackColor = false;
            this.MonstruoButton.Visible = false;
            // 
            // MonstruoBox
            // 
            this.MonstruoBox.BackColor = System.Drawing.Color.Transparent;
            this.MonstruoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MonstruoBox.Image = global::Cho_2._0.Properties.Resources.MonstruoCho11;
            this.MonstruoBox.Location = new System.Drawing.Point(68, 43);
            this.MonstruoBox.Name = "MonstruoBox";
            this.MonstruoBox.Size = new System.Drawing.Size(96, 74);
            this.MonstruoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MonstruoBox.TabIndex = 1;
            this.MonstruoBox.TabStop = false;
            // 
            // CriaturaBox
            // 
            this.CriaturaBox.BackColor = System.Drawing.Color.Transparent;
            this.CriaturaBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CriaturaBox.Image = global::Cho_2._0.Properties.Resources.CriaturaPoro1;
            this.CriaturaBox.Location = new System.Drawing.Point(457, 237);
            this.CriaturaBox.Name = "CriaturaBox";
            this.CriaturaBox.Size = new System.Drawing.Size(68, 60);
            this.CriaturaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CriaturaBox.TabIndex = 3;
            this.CriaturaBox.TabStop = false;
            this.CriaturaBox.Visible = false;
            // 
            // BarLv1
            // 
            this.BarLv1.Location = new System.Drawing.Point(938, 198);
            this.BarLv1.Name = "BarLv1";
            this.BarLv1.Size = new System.Drawing.Size(152, 23);
            this.BarLv1.TabIndex = 4;
            // 
            // Tiempo
            // 
            this.Tiempo.AutoSize = true;
            this.Tiempo.BackColor = System.Drawing.Color.Transparent;
            this.Tiempo.Location = new System.Drawing.Point(935, 138);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(57, 13);
            this.Tiempo.TabIndex = 5;
            this.Tiempo.Text = "Tiempo : 0";
            this.Tiempo.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.Comida.Location = new System.Drawing.Point(938, 171);
            this.Comida.Name = "Comida";
            this.Comida.Size = new System.Drawing.Size(91, 13);
            this.Comida.TabIndex = 6;
            this.Comida.Text = "Criaturas Comidas";
            // 
            // MensajeInicio
            // 
            this.MensajeInicio.AutoSize = true;
            this.MensajeInicio.BackColor = System.Drawing.Color.Transparent;
            this.MensajeInicio.Font = new System.Drawing.Font("Snap ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensajeInicio.ForeColor = System.Drawing.Color.Black;
            this.MensajeInicio.Location = new System.Drawing.Point(109, 194);
            this.MensajeInicio.Name = "MensajeInicio";
            this.MensajeInicio.Size = new System.Drawing.Size(709, 27);
            this.MensajeInicio.TabIndex = 15;
            this.MensajeInicio.Text = "PRESIONA BARRA ESPACIADORA PARA COMENZAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cho_2._0.Properties.Resources.Cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(1062, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cho_2._0.Properties.Resources.FondoPrincipal;
            this.ClientSize = new System.Drawing.Size(1115, 539);
            this.ControlBox = false;
            this.Controls.Add(this.MensajeInicio);
            this.Controls.Add(this.MonstruoBox);
            this.Controls.Add(this.Comida);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.BarLv1);
            this.Controls.Add(this.CriaturaBox);
            this.Controls.Add(this.MonstruoButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nivel  1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MonstruoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriaturaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MonstruoBox;
        private System.Windows.Forms.Button MonstruoButton;
        private System.Windows.Forms.PictureBox CriaturaBox;
        private System.Windows.Forms.ProgressBar BarLv1;
        private System.Windows.Forms.Label Tiempo;
        private System.Windows.Forms.Timer Contadores;
        private System.Windows.Forms.Label Comida;
        private System.Windows.Forms.Label MensajeInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem comenzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

