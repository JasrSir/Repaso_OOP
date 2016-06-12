using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_tiempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tiempo t1 = new Tiempo(int.Parse(mtbH1.Text), int.Parse(mtbM1.Text), int.Parse(mtbS1.Text));
            Tiempo t2 = new Tiempo(int.Parse(mtbH2.Text), int.Parse(mtbM2.Text), int.Parse(mtbS2.Text));
            Tiempo t3 = t1.Suma(t2);
            label3.Text = t3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tiempo t1 = new Tiempo(int.Parse(mtbH1.Text), int.Parse(mtbM1.Text), int.Parse(mtbS1.Text));
            Tiempo t2 = new Tiempo(int.Parse(mtbH2.Text), int.Parse(mtbM2.Text), int.Parse(mtbS2.Text));
            Tiempo t3 = t1.Resta(t2);
            label3.Text = t3.ToString();
        }
    }
}
