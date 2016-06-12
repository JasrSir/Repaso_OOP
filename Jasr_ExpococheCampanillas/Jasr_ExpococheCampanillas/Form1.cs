using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jasr_ExpococheCampanillas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializaEntradas();
        }
        /// <summary>
        /// Creamos la exposición
        /// </summary>
        Exposicion ExpoCampanillas;
        /// <summary>
        /// Inicialización del comboBox Entradas y la actualización de entradas iniciales
        /// </summary>
        private void InicializaEntradas()
        {
            ExpoCampanillas = new Exposicion(25, 1000, 200);
            for (int i = 1; i <= 200; i++)
                cbx_Entradas.Items.Add(i);
            ActualizaEntradas();
        }
        /// <summary>
        /// Método para actualizar las entradas disponibles en sus respectivos labels
        /// </summary>
        private void ActualizaEntradas()
        {
            lbl_ConVen.Text = ExpoCampanillas.Comven.ToString();
            lbl_Prin.Text = ExpoCampanillas.Principal.ToString();
            lbl_Vip.Text = ExpoCampanillas.Vip.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (cbx_Entradas.SelectedIndex != -1 && cbx_Zona.SelectedIndex !=-1)
            {
                if (ExpoCampanillas.SobreTicket(cbx_Entradas.SelectedIndex + 1, cbx_Zona.SelectedIndex))
                    MessageBox.Show("Lo siento, No hay suficientes Tickets", "Demasiados Tickets", MessageBoxButtons.OK);
                else
                {
                    ActualizaEntradas();
                    MessageBox.Show("Su compra se ha realizado con éxito", "Operación Aceptada", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Rellene ambos campos para poder comprar", "Operación Anulada", MessageBoxButtons.OK);
        }
    }
}
