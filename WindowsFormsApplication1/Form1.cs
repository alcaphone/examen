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

        private void BTO_MULT_Click(object sender, EventArgs e)
        {
            double num1, num2, resp;
            num1 = double.Parse(TXT_DATO_1.Text);
            num2 = double.Parse(TXT_DATO_2.Text);
            resp = num1 * num2;
            RESPUESTA.Text ="la solucion es:"+ resp;
        }
    }
}
