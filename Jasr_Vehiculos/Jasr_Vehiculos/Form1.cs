/*---------------------------------------------------------------------------------------
 *      Nombre: Main Form
 *       Autor: Juan Antonio Suárez
 *     Versión: 0.1
 *       Fecha: 12/06/2016
 *  Comentario: Ventana de windows para probar las clases programadas
 *-------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Jasr_Vehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();    
        }
        private int nBicis = 0;
        private int nCoche = 0;
        private List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        private void btn_CrearBici_Click(object sender, EventArgs e)
        {
            nBicis++;
            Bicicleta bici = new Bicicleta();
            listaVehiculos.Add(bici);
            string[] bicifrase = bici.AString();
            listBox1.Items.Add(bicifrase[0] + " " + nBicis + "".PadRight(20 - bicifrase[0].Length) + bicifrase[1].PadRight(10 - bicifrase[1].Length) + bicifrase[2].PadRight(10 - bicifrase[2].Length));
        }

        private void btn_CrearCoche_Click(object sender, EventArgs e)
        {
            nCoche++;
            Coche cochecitto = new Coche();
            listaVehiculos.Add(cochecitto);
            string[] cochefrase = cochecitto.AString();
            cochecitto.AString();
            listBox1.Items.Add(cochefrase[0] + " " + nCoche + "".PadRight(20 - cochefrase[0].Length) + cochefrase[1].PadRight(10 - cochefrase[1].Length) + cochefrase[2].PadRight(10 - cochefrase[2].Length));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if ( listaVehiculos[listBox1.SelectedIndex] is Coche)
                {
                    Coche cocheavanzado = listaVehiculos[listBox1.SelectedIndex] as Coche;
                    cocheavanzado.IrAMontania();
                    listaVehiculos.RemoveAt(listBox1.SelectedIndex);
                    listaVehiculos.Insert(listBox1.SelectedIndex, cocheavanzado);
                }
                else
                {
                    Bicicleta biciavanzado = listaVehiculos[listBox1.SelectedIndex] as Bicicleta;
                    biciavanzado.HacerCaballo();
                    listaVehiculos.RemoveAt(listBox1.SelectedIndex);
                    listaVehiculos.Insert(listBox1.SelectedIndex, biciavanzado);
                }
                ActualizarListBox();
            }
            else
                MessageBox.Show("No has seleccionado ningun vehiculo","Aviso", MessageBoxButtons.OK);
        }

        private void ActualizarListBox()
        {
            listBox1.Items.Clear();
            nCoche = 0;
            nBicis = 0;
            foreach (Vehiculo item in listaVehiculos)
            {
                string[] frase = item.AString();
                if (item is Coche)
                {
                    nCoche++;
                    listBox1.Items.Add(frase[0] + " " + nCoche + "".PadRight(20 - frase[0].Length) + frase[1].PadRight(10 - frase[1].Length) + frase[2].PadRight(10 - frase[2].Length));
                }
                else
                {
                    nBicis++;
                    listBox1.Items.Add(frase[0] + " " + nBicis + "".PadRight(20 - frase[0].Length) + frase[1].PadRight(10 - frase[1].Length) + frase[2].PadRight(10 - frase[2].Length));

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (listaVehiculos[listBox1.SelectedIndex] is Coche)
                {
                    Coche cocheavanzado = listaVehiculos[listBox1.SelectedIndex] as Coche;
                    cocheavanzado.IrdeVacaciones();
                    listaVehiculos.RemoveAt(listBox1.SelectedIndex);
                    listaVehiculos.Insert(listBox1.SelectedIndex, cocheavanzado);
                }
                else
                {
                    Bicicleta biciavanzado = listaVehiculos[listBox1.SelectedIndex] as Bicicleta;
                    biciavanzado.HacerMaraton();
                    listaVehiculos.RemoveAt(listBox1.SelectedIndex);
                    listaVehiculos.Insert(listBox1.SelectedIndex, biciavanzado);
                }
                ActualizarListBox();
            }
            else
                MessageBox.Show("No has seleccionado ningun vehiculo", "Aviso", MessageBoxButtons.OK);

        }
    }
}
