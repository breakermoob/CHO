using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cho_2._0
{
    public partial class Nivel_2 : Form
    {
        
        int imagen = 0, tiempo = 0,lv1 = 0;       
       
        
        PictureBox[,] Obstaculos = new PictureBox[2, 2];
        Rectangle[,] Bloques = new Rectangle[2, 2];
        Rectangle Monstruo = new Rectangle();
        Rectangle Criatura = new Rectangle();
        Random Mov = new Random();
        Random nroAleatorio = new Random();
        
        public Nivel_2()
        {
            InitializeComponent();
            Pierdes.Start();
            Contadores.Stop();
            /////////////////////////////////////
            ////ARREGLO DE OBSTACULOS////////////
            /////////////////////////////////////
            for (int j = 0, y = 150; j < Obstaculos.GetLength(1); j++, y += 200)
            {
                for (int i = 0, x = 150; i < Obstaculos.GetLength(0); i++, x += 500)
                {
                    Obstaculos[i, j] = new PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(Obstaculos[i, j])).BeginInit();
                    this.SuspendLayout();
                    imagen = nroAleatorio.Next(3);

                    if (imagen == 0)
                    {
                        Obstaculos[i, j].Image = global::Cho_2._0.Properties.Resources.Lago;
                    }
                    else
                    {
                        if (imagen == 1)
                        {
                            Obstaculos[i, j].Image = global::Cho_2._0.Properties.Resources.LagoClaro;
                        }
                        else
                        {
                            if (imagen == 2)
                            {
                                Obstaculos[i, j].Image = global::Cho_2._0.Properties.Resources.Lodo;
                            }
                        }
                    }

                    Obstaculos[i, j].Location = new System.Drawing.Point(x, y);
                    Obstaculos[i, j].Name = "bloque" + i;
                    Obstaculos[i, j].Size = new System.Drawing.Size(99, 42);
                    Obstaculos[i, j].TabIndex = 0;
                    Obstaculos[i, j].TabStop = true;
                    Controls.Add(Obstaculos[i, j]);
                    Obstaculos[i, j].Visible = true;

                    Bloques[i, j] = new Rectangle(Obstaculos[i, j].Location.X, Obstaculos[i, j].Location.Y, Obstaculos[i, j].Width, Obstaculos[i, j].Height);

                }

            }
        }

        private void Nivel_2_KeyDown(object sender, KeyEventArgs e)
        {
            /////////////////////////////////////
            ////MOVIMIENTO DEL MonstruoBox///////
            /////////////////////////////////////
            if ((e.KeyData == Keys.A) && (MonstruoBox.Location.X >= 0))
            {
                MonstruoBox.Location = new Point(MonstruoBox.Location.X - 20, MonstruoBox.Location.Y);
            }

            if ((e.KeyData == Keys.D) && (MonstruoBox.Location.X <= 800))
            {
                MonstruoBox.Location = new Point(MonstruoBox.Location.X + 20, MonstruoBox.Location.Y);
            }
            if ((e.KeyData == Keys.W) && (MonstruoBox.Location.Y >= 30))
            {
                MonstruoBox.Location = new Point(MonstruoBox.Location.X, MonstruoBox.Location.Y - 20);
            }

            if ((e.KeyData == Keys.S) && (MonstruoBox.Location.Y <= 500))
            {
                MonstruoBox.Location = new Point(MonstruoBox.Location.X, MonstruoBox.Location.Y + 20);
            }
            /////////////////////////////////////////
            ////MOVIMIENTO DEL MonstruoButton////////
            ////////////////////////////////////////
            if ((e.KeyData == Keys.A) && (MonstruoButton.Location.X >= 0))
            {
                MonstruoButton.Location = new Point(MonstruoButton.Location.X - 20, MonstruoButton.Location.Y);
            }

            if ((e.KeyData == Keys.D) && (MonstruoButton.Location.X <= 800))
            {
                MonstruoButton.Location = new Point(MonstruoButton.Location.X + 20, MonstruoButton.Location.Y);
            }
            if ((e.KeyData == Keys.W) && (MonstruoButton.Location.Y >= 30))
            {
                MonstruoButton.Location = new Point(MonstruoButton.Location.X, MonstruoButton.Location.Y - 20);
            }

            if ((e.KeyData == Keys.S) && (MonstruoButton.Location.Y <= 500))
            {
                MonstruoButton.Location = new Point(MonstruoButton.Location.X, MonstruoButton.Location.Y + 20);
            }
            ///////////////////////////////////
            /////MOVIMIENTO DE LA CRIATURA/////
            ///////////////////////////////////

            if (CriaturaBox.Bounds.IntersectsWith(MonstruoButton.Bounds))
            {
                Move_Criatura();
                lv1 = lv1 + 10;
                Comida.Text = "Ciraturas Comidas : " + lv1;
                BarLv2.Increment(10);
            }
            if (lv1 == 10)
            {
                MessageBox.Show("Nivel 2 Completado");
                MessageBox.Show("Dificultad Aumentada", " Nivel 3", MessageBoxButtons.OK);
                Victory2 frm = new Victory2();
                frm.Show();
                Contadores.Stop();
                this.Close();
            }

            ///////////////////////////////////
            /////AVISOS EN LA PANTALLA/////////
            ///////////////////////////////////
            if (e.KeyData == Keys.Space)
            {
                CriaturaBox.Visible = true;
                Contadores.Start();
                MensajeInicio.Visible = false;
            }
        }
        private void Move_Criatura()
        {
            /////////////////////////////////////
            ////MOVIMIENTO RANDOM////////////////
            /////////////////////////////////////

            
            CriaturaBox.Location = new Point(Mov.Next(650), (Mov.Next(370)));

        }

        private void Pierdes_Tick(object sender, EventArgs e)
        {
            //////////////////////////////////////
            ///COLISION ENTRE MONSTRUO Y LAGOS////
            //////////////////////////////////////
            Monstruo = new Rectangle(MonstruoBox.Location.X, MonstruoBox.Location.Y, MonstruoBox.Width, MonstruoBox.Height);
            for (int j = 0; j < Bloques.GetLength(1); j++)
            {
                for (int i = 0; i < Bloques.GetLength(0); i++)
                {
                    if (Bloques[i,j].IntersectsWith(Monstruo))
                    {
                        MonstruoBox.Location = new Point(Mov.Next(0), (Mov.Next(0)));
                        Defeat frm = new Defeat();
                        this.Close();
                         frm.Show();
                         
                    }
                }
            }

            //////////////////////////////////////
            ///COLISION ENTRE CRIATURA Y LAGOS//// 
            //////////////////////////////////////
            Criatura = new Rectangle(CriaturaBox.Location.X, CriaturaBox.Location.Y, CriaturaBox.Width, CriaturaBox.Height);
            for (int j = 0; j < Bloques.GetLength(1); j++)
            {
                for (int i = 0; i < Bloques.GetLength(0); i++)
                {
                    if (Bloques[i, j].IntersectsWith(Criatura))
                    {
                        Move_Criatura();
                    }
                }
            }
        }
        /////////////////////////////////////
        ///CONTADORES = TIEMPO //////////////
        /////////////////////////////////////
        private void Contadores_Tick(object sender, EventArgs e)
        {
            tiempo++;
            Time.Text = "Tiempo : " + tiempo;
        }
        /////////////////////////////////////
        ///MENU //////COMENZAR //////////////
        /////////////////////////////////////
        private void comenzarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriaturaBox.Visible = true;
            Contadores.Start();
            MensajeInicio.Visible = false;

        }

        /////////////////////////////////////
        ///MENU //////SALIR//////////////////
        /////////////////////////////////////
        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult salirEscape = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo);

            switch (salirEscape)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;

                case DialogResult.No:
                    Cursor.Hide();

                    break;
            }
        }

        /////////////////////////////////////
        ///MENU //////REINICIAR//////////////
        /////////////////////////////////////
        private void reiniciarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tiempo = 0;
            Time.Text = "Tiempo :  " + tiempo;
            BarLv2.Value = 0;
            lv1 = 0;
            Comida.Text = "Ciraturas Comidas : " + lv1;
            Contadores.Stop();
            MensajeInicio.Visible = true;
            CriaturaBox.Visible = false;
        }
        /////////////////////////////////////
        ///MENU //////PAUSAR////////////////
        /////////////////////////////////////
        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Show();
            if (pausarToolStripMenuItem.Text == "Pausar")
            {
                pausarToolStripMenuItem.Text = "Reanudar";
                Contadores.Stop();
                CriaturaBox.Visible = false;
            }
            else
            {
                if (pausarToolStripMenuItem.Text == "Reanudar")
                {
                    pausarToolStripMenuItem.Text = "Pausar";
                    Contadores.Start();
                    CriaturaBox.Visible = true;
                }
            }
        }

        private void MonstruoBox_Click(object sender, EventArgs e)
        {

        }
        /////////////////////////////////////
        ///Boton//////Salir////////////////
        /////////////////////////////////////
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult salirEscape = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo);

            switch (salirEscape)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;

                case DialogResult.No:
                    Cursor.Hide();

                    break;
            }
        }
    }
}
