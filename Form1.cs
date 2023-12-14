using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Retangulo r;
            r = new Retangulo();
            r.setBase(double.Parse(txt1.Text));
            r.setAltura(double.Parse(txt2.Text));
            txtArea.Text = r.CalcularArea().ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
