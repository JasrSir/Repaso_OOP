using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Jasr_ListaEstaticaDinamica
{
    public partial class FormAnimado : Form    
    {
        //Constructor del Form.
        public FormAnimado()
        {
            InitializeComponent();
            //Comprobamos primero que existe o no el archiv de texto
            ComprobarArchivo();
        }

        #region Variables
        //Diccionario creado alfabético de clave y clase anime
        private Anime anime;
        private Dictionary<char, Anime> diccionarioAnime;
        //Ruta, lector y escritor
        static string ruta = Path.GetDirectoryName(Application.ExecutablePath) + "/AnimeList.txt";
        private StreamReader lector;
        private StreamWriter escritor;
        private FileStream flujo;

        #endregion

        #region Métodos
        /// <summary>
        /// Método que comprueba si existe el fichero del diccionario o lo crea.
        /// </summary>
        private void ComprobarArchivo()
        {
            if (File.Exists(ruta))
                RecreaDiccionario();
            else
                CrearDiccionario();
        }
        /// <summary>
        /// Metodo que crea el diccionario
        /// </summary>
        private void CrearDiccionario()
        {
            flujo = File.Open(ruta, FileMode.OpenOrCreate);
            diccionarioAnime = new Dictionary<char, Anime>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                anime = new Anime();
                diccionarioAnime.Add(i, anime);
            }
            Guardar();
        }
        /// <summary>
        /// Método que recrea el diccionario guardado en e fichero.
        /// </summary>
        private void RecreaDiccionario()
        {
            flujo = File.Open(ruta, FileMode.Open);
            lector = new StreamReader(flujo);
            diccionarioAnime = new Dictionary<char, Anime>();

            string lineaActual;
            char clave = 'A';
            Anime animeactual = new Anime();
            Anime animeCompleto;
            while (!lector.EndOfStream)
            {
                lineaActual = lector.ReadLine();

                if (lineaActual.Length == 1)
                {
                    animeCompleto = animeactual;

                    if (clave != char.Parse(lineaActual))
                    {
                        diccionarioAnime.Add(clave, animeCompleto);
                        animeactual = new Anime();
                    }

                    clave = char.Parse(lineaActual);
                }
                else if (lineaActual.Length != 1)
                    animeactual.Aniadir(lineaActual);
            }
            animeCompleto = animeactual;
            diccionarioAnime.Add(clave, animeCompleto);
            lector.Close();
            lector.Dispose();
        }
        /// <summary>
        /// Método que guarda el diccionario en el archivo
        /// </summary>
        private void Guardar()
        {
            if (flujo != null)
            {
                flujo = File.OpenWrite(ruta);
            }
            escritor = new StreamWriter(flujo);
            foreach (char key in diccionarioAnime.Keys)
            {
                escritor.WriteLine(key);
                for (int i = 0; i < diccionarioAnime[key].Cantidad; i++)
                    escritor.WriteLine(diccionarioAnime[key][i]);
            }
            escritor.Close();
            escritor.Dispose();
        }
        /// <summary>
        /// Método que añade un anime si NO existe
        /// </summary>
        /// <param name="nombre">nombre del título de la serie</param>
        private void Aniadir(string nombre)
        {
            try
            {
                char inicial = char.ToUpper(nombre[0]);
                bool aniadidio = diccionarioAnime[inicial].Aniadir(tbx_Anime.Text);
                if (aniadidio)
                    this.Text = "Añadido Correctamente";
                else
                    this.Text = "El anime ya Existía";
            }
            catch (Exception)
            {
                this.Text = "No está la clave";
            }
        }
        /// <summary>
        /// Método que lista el 
        /// </summary>
        private void Listar()
        {
            listBox1.Items.Clear();
            foreach (char key in diccionarioAnime.Keys)
            {
                if (diccionarioAnime[key].Cantidad != 0)
                {
                    listBox1.Items.Add(key);
                    for (int i = 0; i < diccionarioAnime[key].Cantidad; i++)
                        listBox1.Items.Add(diccionarioAnime[key][i]);
                }
            }
        }
        /// <summary>
        /// método que borra un anime si existe
        /// </summary>
        /// <returns>true si lo ha borrado y false si no lo ha borrado</returns>
        private bool Borrar()
        {
            if (listBox1.SelectedItem != null)
            {
                char clave = listBox1.SelectedItem.ToString().ToUpper()[0];
                diccionarioAnime[clave].Eliminar(listBox1.SelectedItem.ToString());
                return true;
            }
            else
                return false;
        }

        #endregion

        #region Eventos
        /// <summary>
        /// Evento que llama al método Aniadir
        /// </summary>
        private void btn_Aniadir_Click(object sender, EventArgs e)
        {
            Aniadir(tbx_Anime.Text);
            //Limpiamos el tbx y le tomamos el foco (facilidad para el usuario)
            tbx_Anime.Clear();
            tbx_Anime.Focus();
            Listar();

        }
        /// <summary>
        /// Evento que llama al metodo Listar
        /// </summary>
        private void btn_Listar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        /// <summary>
        /// Evento que llama al método Guardar
        /// </summary>
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        /// <summary>
        /// Evento al cerrarel formulario que guarda el archivo y cierra el flujo.
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Guardar();
            flujo.Close();

        }
       
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (Borrar())
                this.Text = "Se ha borrado correctamente";
            else
                this.Text = "No se ha podido borrar";
            Listar();
        }

        private void tbx_Anime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btn_Aniadir_Click(null, null);
        } 
        #endregion
    }
}
