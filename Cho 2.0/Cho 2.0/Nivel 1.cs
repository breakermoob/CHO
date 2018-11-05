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
    public partial class Form1 : Form
    {
        int lv1 = 0;
        int tiempo = 0;
        public Form1()
        {
            
            InitializeComponent();
            Contadores.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
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
                lv1 = lv1 + 5;
                Comida.Text = "Ciraturas Comidas : " + lv1;
                BarLv1.Increment(20);
            }
            if (lv1 == 5)
            {
                MessageBox.Show("Nivel 1 Completado");
                MessageBox.Show("Dificultad Aumentada", " Nivel 2");
                Victory1 frm = new Victory1();
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

            Random Mov = new Random();
            CriaturaBox.Location = new Point(Mov.Next(650), (Mov.Next(370)));
            
        }
        /////////////////////////////////////
        ///CONTADORES = TIEMPO //////////////
        /////////////////////////////////////
        private void Contadores_Tick(object sender, EventArgs e)
        {
            tiempo++;
            Tiempo.Text = "Tiempo : " + tiempo;
            
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
        /////////////////////////////////////
        ///MENU //////REINICIAR//////////////
        /////////////////////////////////////

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tiempo = 0;
            Tiempo.Text = "Tiempo :  " + tiempo;
            BarLv1.Value = 0;
            lv1 = 0;
            Comida.Text = "Ciraturas Comidas : " + lv1;
            Contadores.Stop();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
