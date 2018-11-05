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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult salirEscape = MessageBox.Show("¿Desea Reiniciar?", "Reiniciar", MessageBoxButtons.YesNo);

            switch (salirEscape)
            {
                case DialogResult.Yes:
                    Application.Restart();

                    break;

                case DialogResult.No:
                    Application.Exit();

                    break;
            }
        }
    }
}
