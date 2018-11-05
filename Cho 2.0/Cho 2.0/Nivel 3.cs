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
    public partial class Nivel_3 : Form
    {
        int imagen = 0, tiempo = 200, lv1 = 0, tiempoCentinela = 10;

        PictureBox[,] Obstaculos = new PictureBox[4, 4];
        Rectangle[,] Bloques = new Rectangle[4, 4];
        Rectangle Monstruo = new Rectangle();
        Rectangle Criatura = new Rectangle();
        Rectangle Poder = new Rectangle();
        Random Mov = new Random();
        Random nroAleatorio = new Random();
        int[] Y = new int[3] { 91, 382, 563 };
        int[] X = new int[3] { 145, 279, 424 };

        public Nivel_3()
        {
            InitializeComponent();
            PierdesLv3.Start();
            Pierdes2Lv3.Start();
            CentinelaAparicion.Start();
          
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
                    imagen = nroAleatorio.Next(2);

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

        private void Nivel_3_KeyDown(object sender, KeyEventArgs e)
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
            /////MOVIMIENTO DE LA CRIATURA/////
            ///////////////////////////////////

            if (CriaturaBox.Bounds.IntersectsWith(MonstruoBox.Bounds))
            {
                Move_Criatura();
                lv1 = lv1 + 10;
                Comida.Text = "Ciraturas Comidas : " + lv1;
                BarLv3.Increment(10);
            }
            if (lv1 == 10)
            {
                VictoriaLv3 frm = new VictoriaLv3();
                frm.Show();
                ContadoresLv3.Stop();
                this.Close();
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
        private void Move_Criatura()
        {
            /////////////////////////////////////
            ////MOVIMIENTO RANDOM////////////////
            /////////////////////////////////////


            CriaturaBox.Location = new Point(Mov.Next(650), (Mov.Next(370)));

        }

        /////////////////////////////////////
        ///CONTADORES = TIEMPO //////////////
        /////////////////////////////////////

        private void Contadores_Tick(object sender, EventArgs e)
        {
            tiempo--;
            Time.Text = "Tiempo : " + tiempo;
            if (tiempo == 0)
            {
                ContadoresLv3.Stop();
                Defeat frm = new Defeat();
                frm.Show();

            }
           
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
            tiempo = 200;
            Time.Text = "Tiempo :  " + tiempo;
            BarLv3.Value = 0;
            lv1 = 0;
            Comida.Text = "Ciraturas Comidas : " + lv1;
            ContadoresLv3.Stop();
            MensajeInicio.Visible = true;
            CriaturaBox.Visible = false;
        }

        private void Pierdes2Lv3_Tick(object sender, EventArgs e)
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
                    }
                }
            }
            ///////////////////////////////////////
            //// COLISION ENTRE CENTINELA Y LAGOS//
            ///////////////////////////////////////
            Poder = new Rectangle(Centinela.Location.X, Centinela.Location.Y, Centinela.Width, Centinela.Height);
            for (int j = 0; j < Bloques.GetLength(1); j++)
            {
                for (int i = 0; i < Bloques.GetLength(0); i++)
                {
                    if (Bloques[i, j].IntersectsWith(Poder))
                    {
                        Centinela.Location = new Point(Mov.Next(650), (Mov.Next(370)));
                    }
                }
            }
        }
        ///////////////////////////////////////
        //////// LABEL DE TIEMPO PODER/////////
        ///////////////////////////////////////
        private void TiempoPoder_Tick(object sender, EventArgs e)
        {
            tiempoCentinela--;
            Duracion.Text = "Duracion Efecto : " + tiempoCentinela;

            if (tiempoCentinela == 0)
            {
                Centinela.Location = new Point(Mov.Next(650), (Mov.Next(370)));
                Centinela.Location = new Point(926, 118);
                Pierdes2Lv3.Start();
                TiempoPoder.Stop();
                tiempoCentinela = 10; 
                Duracion.Text = "Duracion Efecto : " + tiempoCentinela;
                Duracion.Visible = false;
            }
        }

        private void CentinelaAparicion_Tick(object sender, EventArgs e)
        {
            /////////////////////////////////////
            //// APARICION DEL CENTINELA ////////
            /////////////////////////////////////

            if (tiempo == 195)
            {
                Centinela.Location = new Point(Mov.Next(650), (Mov.Next(370)));

            }
            if (tiempo == 160)
            {
                Centinela.Location = new Point(Mov.Next(650), (Mov.Next(370)));

            }

            if (tiempo == 180)
            {
                Centinela.Location = new Point(926, 118);

            }

            if (tiempo == 140)
            {
                Centinela.Location = new Point(926, 118);

            }
            if (tiempo == 100)
            {
                Centinela.Location = new Point(Mov.Next(650), (Mov.Next(370)));

            }
            if (tiempo == 800)
            {
                Centinela.Location = new Point(926, 118);

            }

            if (tiempo == 50)
            {
                Centinela.Location = new Point(Mov.Next(650), (Mov.Next(370)));

            }
            if (tiempo == 40)
            {
                Centinela.Location = new Point(926, 118);

            }

            ////////////////////////////////////////////
            ////COLISION ENTRE CENTINELA Y MONSTRUO/////
            ////////////////////////////////////////////
            if (Poder.IntersectsWith(Monstruo))
            {
                Pierdes2Lv3.Stop();
                TiempoPoder.Start();
                Duracion.Visible = true;
                Centinela.Location = new Point(926, 118);
            }
           
        }
        ////////////////////////////////////////
        //// BOTON DE SALIDA LATERAL DERECHO////
        ///////////////////////////////////////
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

        private void PierdesLv3_Tick(object sender, EventArgs e)
        {
            ////////////////////////////////////////
            //// COLISION ENTRE CRIATURA Y LAGOS////
            ///////////////////////////////////////
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

    }
}

