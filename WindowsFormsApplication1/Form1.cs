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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = double.Parse(txt_num.Text);
            y = double.Parse(txt_num1.Text);


            z= x-y;

            label2.Text = "EL RESULTADO ES:" + z;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
