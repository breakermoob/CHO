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
    public partial class Inicio : Form
    {
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(Cho_2._0.Properties.Resources.Cho_Audio);
        
        public Inicio()
        {
            InitializeComponent();
            startSoundPlayer.Play();            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Modos frm = new Modos();
            frm.Show();
            startSoundPlayer.Stop();
            this.Hide();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
