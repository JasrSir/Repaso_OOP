using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasr_ExpococheCampanillas
{
    class Exposicion
    {
        #region Campos, Propiedades, estructura y Consructores
        private int _vip;
        private int _principal;
        private int _comven;
        private enum lugares
        {
            principal,
            comven,
            vip
        };

        public int Vip
        {
            get
            {
                return _vip;
            }

            private set
            {
                _vip = value;
            }
        }

        public int Principal
        {
            get
            {
                return _principal;
            }

            private set
            {
                _principal = value;
            }
        }

        public int Comven
        {
            get
            {
                return _comven;
            }

            private set
            {
                _comven = value;
            }
        }

        public Exposicion(int vip, int principal, int comven)
        {
            Vip = vip;
            Principal = principal;
            Comven = comven;
        }
        public Exposicion()
        {
            Vip = 25;
            Principal = 1000;
            Comven = 200;
        }

        #endregion
        /// <summary>
        /// Método que compruba si hay más entradas a comprar que tickets hay
        /// , Si se pudiera realizar la compra se llama al método que lo realiza
        /// </summary>
        /// <param name="entradas">entradas a comprar</param>
        /// <param name="lugar">Zona donde se quiere comprar la entrada</param>
        /// <returns>true si NO se puede realizar y false si se ha realizado con exito</returns>
        public bool SobreTicket(int entradas, int lugar)
        {
            if ((int)lugares.principal == lugar)
            {
                 if (entradas > Principal)
                     return true;
            }
            else if ((int)lugares.comven == lugar)
            {
                if (entradas > Comven)
                    return true;
            }
            else if ((int)lugares.vip == lugar)
            {
                if (entradas > Vip)
                    return true;
            }
            ///Si no hay más tickets pedidos que plazas
            RestarEntradas(entradas, lugar);
            return false;

        }
        /// <summary>
        /// Método que compra entrada y resta en a propiedad adecuada
        /// </summary>
        /// <param name="entradas">entradas a comprar</param>
        /// <param name="lugar">Zona para la compra de entradas</param>
        private void RestarEntradas(int entradas, int lugar)
        {
            if ((int)lugares.principal == lugar)
                Principal -= entradas;
            else if ((int)lugares.comven == lugar)
                Comven -= entradas;
            else if ((int)lugares.vip == lugar)
                Vip -= entradas;
        }
    }
}
