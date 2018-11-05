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
    public partial class Multiplayer : Form
    {
        int imagen = 0, tiempo = 0;

        PictureBox[,] Obstaculos = new PictureBox[4, 4];
        Rectangle[,] Bloques = new Rectangle[4, 4];
        Rectangle Monstruo = new Rectangle();
        Rectangle Criatura = new Rectangle();
        Random Mov = new Random();
        Random nroAleatorio = new Random();
        

        public Multiplayer()
        {
            InitializeComponent();
            Pierdes.Start();
            

            /////////////////////////////////////
            ////ARREGLO DE OBSTACULOS////////////
            /////////////////////////////////////
            for (int j = 0, y = 70; j < Obstaculos.GetLength(1); j++, y += 140)
            {
                for (int i = 0, x = 90; i < Obstaculos.GetLength(0); i++, x += 180)
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

        private void Multiplayer_KeyDown(object sender, KeyEventArgs e)
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
            ///////////////////////////////////
            /////COLICIONES DE LA CRIATURA/////
            ///////////////////////////////////

            if (CriaturaBox.Bounds.IntersectsWith(MonstruoBox.Bounds))
            {
                Defeat frm = new Defeat();
                frm.Show();
            }

            /////////////////////////////////////
            ////MOVIMIENTO DEL CriaturaBox///////
            /////////////////////////////////////
            if ((e.KeyData == Keys.Left) && (CriaturaBox.Location.X >= 0))
            {
                CriaturaBox.Location = new Point(CriaturaBox.Location.X - 20, CriaturaBox.Location.Y);
            }

            if ((e.KeyData == Keys.Right) && (CriaturaBox.Location.X <= 800))
            {
                CriaturaBox.Location = new Point(CriaturaBox.Location.X + 20, CriaturaBox.Location.Y);
            }
            if ((e.KeyData == Keys.Up) && (CriaturaBox.Location.Y >= 30))
            {
                CriaturaBox.Location = new Point(CriaturaBox.Location.X, CriaturaBox.Location.Y - 20);
            }

            if ((e.KeyData == Keys.Down) && (CriaturaBox.Location.Y <= 500))
            {
                CriaturaBox.Location = new Point(CriaturaBox.Location.X, CriaturaBox.Location.Y + 20);
            }

            ///////////////////////////////////
            /////AVISOS EN LA PANTALLA/////////
            ///////////////////////////////////
            if (e.KeyData == Keys.Space)
            {
                CriaturaBox.Visible = true;
                ContadoresLv3.Start();
                MensajeInicio.Visible = false;
            }
        }

        private void ContadoresLv3_Tick(object sender, EventArgs e)
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
            ContadoresLv3.Start();
            MensajeInicio.Visible = false;
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
                ContadoresLv3.Stop();
                CriaturaBox.Visible = false;
            }
            else
            {
                if (pausarToolStripMenuItem.Text == "Reanudar")
                {
                    pausarToolStripMenuItem.Text = "Pausar";
                    ContadoresLv3.Start();
                    CriaturaBox.Visible = true;
                }

            }
        }

        /////////////////////////////////////
        ///MENU //////REINICIAR//////////////
        /////////////////////////////////////

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tiempo = 0;
            Time.Text = "Tiempo :  " + tiempo;
            BarLv3.Value = 0;
            ContadoresLv3.Stop();
            MensajeInicio.Visible = true;
            CriaturaBox.Visible = false;
        }


        /////////////////////////////////////
        ///MENU //////SALIR//////////////////
        /////////////////////////////////////

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
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
                    if (Bloques[i, j].IntersectsWith(Monstruo))
                    {
                        MonstruoBox.Location = new Point(Mov.Next(0), (Mov.Next(0)));
                        Defeat frm = new Defeat();
                        frm.Show();
                        MessageBox.Show("El monstruo ha caido en un lago, la criatura gana");
                        this.Close();
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
                        CriaturaBox.Location = new Point(Mov.Next(0), (Mov.Next(0)));
                        Defeat frm = new Defeat();
                        frm.Show();
                        MessageBox.Show("La Cratura ha caido en un lago. El monstruo gana");
                        this.Close();
                    }
                }
            }

            //////////////////////////////////////
            //COLISION ENTRE CRIATURA Y MONSTRUO//
            //////////////////////////////////////
            for (int j = 0; j < Bloques.GetLength(1); j++)
            {
                for (int i = 0; i < Bloques.GetLength(0); i++)
                {
                    if (Criatura.IntersectsWith(Monstruo))
                    {
                        CriaturaBox.Location = new Point(1049, 268);                      
                        MessageBox.Show("El monstruo se ha comido a la Criatura");
                        VictoryMultijugador frm = new VictoryMultijugador();
                        frm.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
