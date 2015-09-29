using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bto_calcular_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = int.Parse(txt_1.Text);
            y = int.Parse(txt_2.Text);
            z = x + y;
            lbl_resultado.Text = z+"";
        }
    }
}
