/*---------------------------------------------------------------------------------------
 *      Nombre: Clase Abstracta Vehículo y Selladas Bicicleta y Coche
 *       Autor: Juan Antonio Suárez Rosa
 *     Versión: 0.1
 *       Fecha: 12/06/2016
 *  Comentario: Queremos simular la creación de la clase Vehículo y 2 clases
 *              que heredan de ella (bicicleta y coche) y simulen varios comportamientos
 *              sobre sus propiedades.
 *-------------------------------------------------------------------------------------*/
using System;

namespace Jasr_Vehiculos
{
    /// <summary>
    /// Clase abstracta vehículo
    /// </summary>
    abstract class Vehiculo
    {
        #region Campos y Propiedades
        private string _vehiculoCreado;
        private int _kilometrosTotales;
        private int _kilometrosRecorridos;
        protected Random rnd;
        /// <summary>
        /// Propiedad del nombre del vehículo creado
        /// </summary>
        protected string VehiculoCreado
        {
            get
            {
                return _vehiculoCreado;
            }

             set
            {
                _vehiculoCreado = value;
            }
        }
        /// <summary>
        /// Propiedad de los KilometrosTotales del vehículo creado
        /// </summary>
        protected int KilometrosTotales
        {
            get
            {
                return _kilometrosTotales;
            }

             set
            {
                _kilometrosTotales = value;
            }
        }
        /// <summary>
        /// Propiedad de los KilometrosRecorridos del vehículo creado
        /// </summary>
        protected int KilometrosRecorridos
        {
            get
            {
                return _kilometrosRecorridos;
            }

            set
            {
                _kilometrosRecorridos = value;
                KilometrosTotales += _kilometrosRecorridos;
            }
        }
        #endregion
        /// <summary>
        /// Metodo abstracto AString 
        /// </summary>
        /// <returns>Devuelve un array de string con los datos del vehículo
        /// [0] Nombre del vehículo
        /// [1] Kilometros Recorridos
        /// [2] Kilometros Totales</returns>
        public abstract string[] AString();
    }
    /// <summary>
    /// Clase Sellada Bicicleta que hereda de Vehículo
    /// </summary>
    sealed class Bicicleta : Vehiculo
    {
        /// <summary>
        /// Constructor de Bicicleta que inicializa las propiedades y Random
        /// </summary>
        public Bicicleta()
        {
            this.VehiculoCreado = "Bicicleta";
            this.KilometrosTotales = 0;
            this.KilometrosRecorridos = 0;
            this.rnd = new Random();
        }
        /// <summary>
        /// Método que hace el caballito de 0 a 50 km
        /// </summary>
        /// <returns>devuelve los kilometros a string</returns>
        public string HacerCaballo()
        {
            this.KilometrosRecorridos = this.rnd.Next(50);
            return this.KilometrosRecorridos.ToString();
        }
        /// <summary>
        /// Método que hace una maratón de 50 a 99km
        /// </summary>
        /// <returns>devuelve los kilometros a string</returns>
        public string HacerMaraton()
        {
            this.KilometrosRecorridos = this.rnd.Next(50,99);
            return this.KilometrosRecorridos.ToString();
        }
        /// <summary>
        /// Metodo sobreescrito AString 
        /// </summary>
        /// <returns>Devuelve un array de string con los datos del vehículo
        /// [0] Nombre del vehículo
        /// [1] Kilometros Recorridos
        /// [2] Kilometros Totales</returns>
        public override string[] AString()
        {
            string[] frase = new string[3];
            frase[0] = this.VehiculoCreado;
            frase[1] = this.KilometrosRecorridos.ToString();
            frase[2] = this.KilometrosTotales.ToString();
            return frase;
        }
    }
    /// <summary>
    /// Clase Sellada Coche que hereda de Vehículo
    /// </summary>
    sealed class Coche : Vehiculo
    {
        /// <summary>
        /// Constructor de Coche que inicializa las propiedades y Random
        /// </summary>
        public Coche()
        {
            this.VehiculoCreado = "Coche";
            this.KilometrosTotales = 0;
            this.KilometrosRecorridos = 0;
            this.rnd = new Random();
        }
        /// <summary>
        /// Método que pasea el coche de 0 a 200 km
        /// </summary>
        /// <returns>devuelve los kilometros a string</returns>
        public string IrAMontania()
        {
            this.KilometrosRecorridos = this.rnd.Next(200);
            return this.KilometrosRecorridos.ToString();
        }
        /// <summary>
        /// Método que anda el coche de 200 a 500 km
        /// </summary>
        /// <returns>devuelve los kilometros a string</returns>
        public string IrdeVacaciones()
        {
            this.KilometrosRecorridos = this.rnd.Next(200,500);
            return this.KilometrosRecorridos.ToString();
        }
        /// <summary>
        /// Metodo sobreescrito AString 
        /// </summary>
        /// <returns>Devuelve un array de string con los datos del vehículo
        /// [0] Nombre del vehículo
        /// [1] Kilometros Recorridos
        /// [2] Kilometros Totales</returns>
        public override string[] AString()
        {
            string[] frase = new string[3];
            frase[0] = this.VehiculoCreado;
            frase[1] = this.KilometrosRecorridos.ToString();
            frase[2] = this.KilometrosTotales.ToString();
            return frase;
        }
    }
}
