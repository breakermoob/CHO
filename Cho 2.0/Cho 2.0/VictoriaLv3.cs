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
    public partial class VictoriaLv3 : Form
    {
        public VictoriaLv3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nivel_4 form = new Nivel_4();
            form.Show();
            this.Close();
        }
    }
}
