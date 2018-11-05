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
    public partial class Modos : Form
    {
        public Modos()
        {
            InitializeComponent();
        }

        private void dosJugadores_Click(object sender, EventArgs e)
        {
            Multiplayer fm = new Multiplayer();
            fm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

    }
}
