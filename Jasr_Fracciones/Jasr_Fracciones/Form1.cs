using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jasr_Fracciones
{
    public partial class Form1 : Form
    {
        Fraccion fraccion1;
        Fraccion fraccion2;
        
        public Form1()
        {
            InitializeComponent();
           fraccion1 = new Fraccion();
           fraccion2 = new Fraccion();
        }

        private bool ComprobarFracciones1()
        {
            if (fr1_Num.Text != "0" && fr1_Den.Text != "0")
                return true;
            return false;
        }
        private bool ComprobarFracciones2()
        {
            if (fr2_Num.Text != "0" && fr2_Den.Text != "0")
                return true;
            return false;
        }

        private void btn_Simplif_Click(object sender, EventArgs e)
        {
            if (ComprobarFracciones1())
            {
                fraccion1.Simplifica();
                fr1_Num.Text = fraccion1.Numerador.ToString();
                fr1_Den.Text = fraccion1.Denominador.ToString();
            }
            if (ComprobarFracciones2())
            {
                fraccion2.Simplifica();
                fr2_Num.Text = fraccion2.Numerador.ToString();
                fr2_Den.Text = fraccion2.Denominador.ToString();
            }
                
        }
        
        private void btn_Suma_Click(object sender, EventArgs e)
        {
            Fraccion resultado;
            if (ComprobarFracciones1() && ComprobarFracciones2())
            {
                resultado = Fraccion.Suma(fraccion1, fraccion2);
                fr1_Num.Text = resultado.Numerador.ToString();
                fr1_Den.Text = resultado.Denominador.ToString();
                fr2_Num.Text = "0";
                fr2_Den.Text = "0";
            }
        }
        private void fr1_Den_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
            if (((TextBox)sender).Text != "0")
	        {
		         switch (((TextBox)sender).Name)
                    {
                        case "fr1_Num":
                            fraccion1.Numerador = int.Parse(((TextBox)sender).Text);
                            break;
                        case "fr1_Den":
                            fraccion1.Denominador = int.Parse(((TextBox)sender).Text);
                            break;
                        case "fr2_Num":
                            fraccion2.Numerador = int.Parse(((TextBox)sender).Text);
                            break;
                        case "fr2_Den":
                            fraccion2.Denominador = int.Parse(((TextBox)sender).Text);
                            break;
                    }
	        }
            
        }

        private void btn_Invi_Click(object sender, EventArgs e)
        {
            if (ComprobarFracciones1())
            {
                fraccion1.Invierte();
                fr1_Num.Text = fraccion1.Numerador.ToString();
                fr1_Den.Text = fraccion1.Denominador.ToString();
            }
            if (ComprobarFracciones2())
            {
                fraccion2.Invierte();
                fr2_Num.Text = fraccion2.Numerador.ToString();
                fr2_Den.Text = fraccion2.Denominador.ToString();
            }
        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            Fraccion resultado;
            if (ComprobarFracciones1() && ComprobarFracciones2())
            {
                resultado = Fraccion.Resta(fraccion1, fraccion2);
                fr1_Num.Text = resultado.Numerador.ToString();
                fr1_Den.Text = resultado.Denominador.ToString();
                fr2_Num.Text = "0";
                fr2_Den.Text = "0";
            }
        }

        private void btn_Multipli_Click(object sender, EventArgs e)
        {
            Fraccion resultado;
            if (ComprobarFracciones1() && ComprobarFracciones2())
            {
                resultado = Fraccion.Multiplica(fraccion1, fraccion2);
                fr1_Num.Text = resultado.Numerador.ToString();
                fr1_Den.Text = resultado.Denominador.ToString();
                fr2_Num.Text = "0";
                fr2_Den.Text = "0";
            }
        }

        private void btn_Divi_Click(object sender, EventArgs e)
        {
            Fraccion resultado;
            if (ComprobarFracciones1() && ComprobarFracciones2())
            {
                resultado = Fraccion.Divide(fraccion1, fraccion2);
                fr1_Num.Text = resultado.Numerador.ToString();
                fr1_Den.Text = resultado.Denominador.ToString();
                fr2_Num.Text = "0";
                fr2_Den.Text = "0";
            }
        }

        
    }
}
