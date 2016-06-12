using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jasr_PulsarBotones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variable Booleana Pulsada y Punto de referencia
        //El punto de referencia es para que el ratón se quede en el sitio
        //donde pinchas y no se vaya a la esquina sup izq del botón.
        private bool pulsada = false;
        private Point punto;
        
        //Método que pone la variable booleana pulsada a true y guarda el punto de referencia del ratón
        private void BotonPulsado(object sender, MouseEventArgs e)
        {
            pulsada = true;
            punto.X = e.X;
            punto.Y = e.Y;
        }

        //Método que mueve el boton seleccionado.
        private void Moviendo(object sender, MouseEventArgs e)
        {
            if (pulsada) //Si está pulsada
            {
                ///Para ello tenemos que sumarle al Left y Top por separado la e(ratón)
                ///y restarle el punto de referencia anterior.


                //X o left
                //Si es menor que 0,es decir, si se sale por la izquierda
                if (((Button)sender).Left + e.X - punto.X <0)
                    ((Button)sender).Left = 0;
                //Si es más que el ancho se queda en el tope
                // si la posición mas el ancho del boton es mayor que el ancho del area de cliente
                else if (((Button)sender).Left + e.X - punto.X + ((Button)sender).Size.Width > this.ClientSize.Width)
                    ((Button)sender).Left = this.ClientSize.Width - ((Button)sender).Size.Width;
                else
                    //Sino en su posición
                    ((Button)sender).Left = ((Button)sender).Left + e.X - punto.X;


                //Y o Top
                //Si es menor que 0, se sale por abajo
                if (((Button)sender).Top + e.Y - punto.Y < 0)
                    ((Button)sender).Top = 0;
                //Si es más que el alto se queda en el tope
                // si la posición mas el alto del boton es mayor que el alto del area  de cliente
                else if (((Button)sender).Top + e.Y - punto.Y + ((Button)sender).Size.Height > this.ClientSize.Height)
                    ((Button)sender).Top = this.ClientSize.Height - ((Button)sender).Size.Height;
                else
                    //Sino en su posicion
                    ((Button)sender).Top = ((Button)sender).Top + e.Y - punto.Y;
            }
        }

        #region Eventos
        //al mover el ratón con el click hecho sobre un botón.
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Moviendo(sender, e);
        }
        //Al pulsar el click del raton
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            BotonPulsado(sender, e);
        }
        //Al levantar el click del ratón
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            pulsada = false;
        }

        #endregion
        
    }
}
