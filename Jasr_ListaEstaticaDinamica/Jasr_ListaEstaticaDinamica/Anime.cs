using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasr_ListaEstaticaDinamica
{
    //Lista estática que se va a comportar de forma dinámica
    class Anime
    {
        #region Campos, Propiedades y Constructor
        //Campos
        private int _capacidad;
        private int _cantidad;
        private string[] arrayAnime;
        
        /// <summary>
        /// int32 get private set de la capacidad total del array
        /// </summary>
        public int Capacidad
        {
            get { return _capacidad; }
            private set { _capacidad = value; } //Cambiar aqui por ampliarlo automaticamente
        }
        /// <summary>
        /// int32 get, private set de la capacidad ocupada del array
        /// </summary>
        public int Cantidad
        {
            get { return _cantidad; }
            private set { _cantidad = value; }
        }

        /// <summary>
        /// COnstructor de un anime
        /// </summary>
        public Anime()
        {
            Capacidad = 5;
            Cantidad = 0;
            arrayAnime = new string[Capacidad];
        }
        
        /// <summary>
        /// Índice del array
        /// </summary>
        /// <param name="i">posición en el array</param>
        /// <returns>el string de la posición indicada</returns>
        public string this[int i]
        {
            get { return arrayAnime[i]; }
            set 
            { 
                arrayAnime[i] = value;
 
            }
        }
        #endregion

        /// <summary>
        /// Método que amplia la capacidad de la lista automáticamente
        /// </summary>
        private void AmpliarCapacidad()
        {
            if (Capacidad == Cantidad)
            {
                Capacidad += 5;
                string[] ampliacion = new string[Capacidad];
                for (int i = 0; i < Cantidad; i++)
                    ampliacion[i] = arrayAnime[i];
                
                arrayAnime = ampliacion;
            }
        }

        /// <summary>
        /// Método que añade otra serie en el array correspondiente
        /// </summary>
        /// <param name="anime">Nombre anime a añadir</param>
        /// <returns>true si se ha insertado y false si ya existe y no se inserta</returns>
        public bool Aniadir(string anime)
        {
            if (Buscar(anime) == -1)
            {
                arrayAnime[Cantidad] = anime;
                Cantidad++;
                AmpliarCapacidad();
                Ordenar();
                return true;
            }
            return false;
            
        }
        /// <summary>
        /// Método que busca una serie en la lista.
        /// </summary>
        /// <param name="buscado">frase a buscar</param>
        /// <returns>el int32 de la posición o -1 si no lo encuentra</returns>
        public int Buscar(string buscado)
        {
            for (int i = 0; i < Cantidad; i++)
                if (buscado.ToLower() == arrayAnime[i].ToLower())
                    return i;

            return -1;
        }

        /// <summary>
        /// Método que Busca y elimina
        /// </summary>
        /// <param name="anime">anime a buscar</param>
        /// <returns>true si lo ha eliminado y false si no lo ha encontrado</returns>
        public bool Eliminar(string anime)
        {
            string[] arrayEliminado = new string[Capacidad];
            bool eliminado = false;

            for (int i = 0; i < Cantidad; i++)
            {
                if (arrayAnime[i].ToLower() != anime.ToLower())
                {
                    if (!eliminado)
                        arrayEliminado[i] = arrayAnime[i];
                    else
                        arrayEliminado[i-1] = arrayAnime[i];
                }
                else
                {
                    Cantidad--;
                    eliminado = true;
                }   
            }
            return eliminado;
        }

        private void Ordenar()
        {
            string tmp;

            for (int i = 0; i < Cantidad; i++)
            {
                for (int j = 0; j < Cantidad; j++)
                {
                    arrayAnime[i].CompareTo(arrayAnime[i+1]);
                }
            }
        }
    }
}
