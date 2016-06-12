using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasr_Fracciones
{
    class Fraccion
    {
        #region Campos y propiedades
        private int _numerador;
        private int _denominador;

        public int Numerador
        {
            get { return _numerador; }
            set { _numerador = value; }
        }

        public int Denominador
        {
            get { return _denominador; }
            set { _denominador = value; }
        }

        #endregion

        #region Constructores
        public Fraccion()
        {
            Numerador = 0;
            Denominador = 0;
        }
        public Fraccion(int numerad, int denominad)
        {
            Numerador = numerad;
            Denominador = denominad;
        } 
        #endregion

        public bool Invierte()
        {
            try
            {
                int tmp = this.Numerador;
                Numerador = this.Denominador;
                Denominador = tmp;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Simplifica()
        {
            for (int j = 0; j < 2; j++)
            {
                for (int i = 2; i <= 10; i++)
                {
                    if (this.Numerador % i == 0 && this.Denominador % i == 0)
                    {
                        this.Numerador /= i;
                        this.Denominador /= i;
                        i--;
                    }
                } 
            }
        }

        public static Fraccion Multiplica(Fraccion frac1, Fraccion frac2)
        {
            Fraccion resultado = new Fraccion();
            resultado.Numerador = frac1.Numerador * frac2.Numerador;
            resultado.Denominador = frac1.Denominador * frac2.Denominador;

            return resultado;
        }

        public static Fraccion Divide(Fraccion frac1, Fraccion frac2)
        {
            Fraccion resultado = new Fraccion();
            resultado.Numerador = frac1.Numerador * frac2.Denominador;
            resultado.Denominador = frac1.Denominador * frac2.Numerador;

            return resultado;
        }

        public static Fraccion Suma(Fraccion frac1, Fraccion frac2)
        {
            Fraccion resultado = new Fraccion();
            if (frac1.Denominador == frac2.Denominador)
            {
                resultado.Numerador = frac1.Numerador + frac2.Numerador;
                resultado.Denominador = frac1.Denominador;
            }
            else
            {
                resultado.Numerador = (frac1.Numerador * frac2.Denominador) + (frac1.Denominador * frac2.Numerador);
                resultado.Denominador = frac1.Denominador * frac2.Denominador;
            }
            
            return resultado;
        }

        public static Fraccion Resta(Fraccion frac1, Fraccion frac2)
        {
            Fraccion resultado = new Fraccion();
            if (frac1.Denominador == frac2.Denominador)
            {
                resultado.Numerador = frac1.Numerador - frac2.Numerador;
                resultado.Denominador = frac1.Denominador;
            }
            else
            {
                resultado.Numerador = (frac1.Numerador * frac2.Denominador) - (frac1.Denominador * frac2.Numerador);
                resultado.Denominador = frac1.Denominador * frac2.Denominador;
            }

            return resultado;
        }

       
    }
}
