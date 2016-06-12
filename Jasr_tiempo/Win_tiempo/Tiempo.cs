using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_tiempo
{
    class Tiempo
    {
        #region Campos, Propiedades, Constructor
        private int _hora;
        private int _minutos;
        private int _segundos;

        private int Hora
        {
            get
            {
                return _hora;
            }

            set
            {
                _hora = value;
            }
        }

        private int Minutos
        {
            get
            {
                return _minutos;
            }

            set
            {
                if(value >=60)
                {
                    int horas = value / 60;
                    Hora += horas;
                    _minutos = value % 60;
                }
                else if (value <0)
                {
                    int horasmenos = (value*-1)/60  ;
                    horasmenos++;
                    Hora -= horasmenos;
                    int valorrestado = 60 - ((value * -1) % 60);
                    _minutos = valorrestado;
                }
                else
                    _minutos = value;
            }
        }

        private int Segundos
        {
            get
            {
                return _segundos;
            }

            set
            {
                if (value >= 60)
                {
                    int minutos =  value / 60 ;
                    Minutos += minutos;
                    _segundos = (value % 60);
                }
                else if (value < 0)
                {
                    int minusmenos = (value * -1) / 60;
                    minusmenos++;
                    Minutos -= minusmenos;
                    int valorrestado = 60 - ((value * -1) % 60);
                    _segundos = valorrestado;
                }
                else
                    _segundos = value;
            }
        }

        public Tiempo(int hora, int minutos, int segundos)
        {
            Hora = hora;
            Minutos = minutos;
            Segundos = segundos;
        }

        #endregion

        public override string ToString()
        {
            return string.Format("{0}h {1}m {2}s", Hora, Minutos, Segundos);
        }

        public Tiempo Suma(Tiempo t)
        {
            Tiempo tiempoResuelto = new Tiempo(this.Hora + t.Hora, this.Minutos + t.Minutos, this.Segundos + t.Segundos);
            return tiempoResuelto;
        }
        public Tiempo Resta(Tiempo t)
        {
            Tiempo tiempoResuelto = new Tiempo(this.Hora - t.Hora, this.Minutos - t.Minutos, this.Segundos - t.Segundos);
            return tiempoResuelto;
        }
    }
}
