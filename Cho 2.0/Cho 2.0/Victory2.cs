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
    public partial class Victory2 : Form
    {
        public Victory2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            Nivel_3 form = new Nivel_3();
            form.Show();
            this.Close();                            
        }
    }
}
