using reproductorcampos.claseslistcirculares.CircularDefinicion;
using reproductorcampos.claseslistdobleenlasada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reproductorcampos
{
    public partial class Reproductor : Form
    {
        //abrir ventana de seleccion de archivos
        Lista addlist = new Lista();
        ClsListaDoble addDoble = new ClsListaDoble();
        ClsListaCircularBase liscircular = new ClsListaCircularBase();
        OpenFileDialog addpath = new OpenFileDialog();
        Nodos nuevo;


        public Reproductor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }



        private void buttonagregar_Click(object sender, EventArgs e)
        {
            //ponemos los tipos de archivos qu se pueden abrir
            try {
            string archivos = "Archivos audios (*.mp3),(*.mp4),(*.wav),(*.png)|";
            addpath.Multiselect = true;
            addpath.Filter = archivos;
            //agregamos a la lista enlazada las canciones seleccionadas
            if (addpath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                for (int i = 0; i < addpath.SafeFileNames.Length; i++)
                {
                        //lista simple
                        //addlist.insertarCanciones(addpath.FileNames[i]);
                        //lista doble
                        addDoble.insertarcabezaLista(addpath.FileNames[i]);
                        
                        //lista circular
                    liscircular.insertar(addpath.FileNames[i]);
                    CANCIONES.Items.Add(addpath.SafeFileNames[i]);

                }

                    //cuando se ejecute y se inserte la primer cancion se ejecutara la del indice 0
                    axWindowsMediaPlayer1.URL = addpath.FileNames[0];
                    CANCIONES.SelectedIndex = 0;
                    


                    int pausa;
                    pausa = 0;
                }

            
            }catch(Exception en)
            {
                //mostramos el error si es que existe
                MessageBox.Show(en.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void CANCIONES_SelectedIndexChanged(object sender, EventArgs e)
        {
            //muestra las canciones seleccionadas
            if (CANCIONES.SelectedIndex != -1)
            {
                axWindowsMediaPlayer1.URL = addpath.FileNames[CANCIONES.SelectedIndex];
                int index = CANCIONES.SelectedIndex;
                nuevo = new Nodos(addpath.FileNames[index]);
            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            int indice = CANCIONES.SelectedIndex;
            if (CANCIONES.SelectedIndex != -1)
            {


                //lista simple
                //addlist.deleteMusic(indice);
                //CANCIONES.Items.RemoveAt(indice);
                //axWindowsMediaPlayer1.Ctlcontrols.stop();

                //lista doblemente enlazada
                string indi = Convert.ToString(indice);
                addDoble.eliminar(indi);
                CANCIONES.Items.RemoveAt(indice);
                axWindowsMediaPlayer1.Ctlcontrols.stop();

                //lista circular
                //string indi = Convert.ToString(indice);
                //liscircular.eliminar(indi);
                //CANCIONES.Items.RemoveAt(indice);
                //axWindowsMediaPlayer1.Ctlcontrols.stop();

            }

           
        }

        private void buttonanterior_Click(object sender, EventArgs e)
        {
            if (CANCIONES.SelectedIndex > 0)
            {
                CANCIONES.SelectedIndex -= 1;
            }
        }

        private void buttonsiguiente_Click(object sender, EventArgs e)
        {
            if (CANCIONES.SelectedIndex < CANCIONES.Items.Count - 1)
            {
                CANCIONES.SelectedIndex += 1;
            }
        }

        private void buttonpausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        
        }

        private void buttonplay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
          

        }

        private void macTrackBar2_ValueChanged(object sender, decimal value)
        {
            //aqui muestra
            minutero.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;

            if (minutero.Value == (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition)
            {

            }
            else
            {

                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = minutero.Value;

            }
        }

        private void buttonstop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
           

        }

        public void actualizadatostrack()
        {
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                volumen.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }else if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }else if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                //volumen.Value = 0; 
            }
        }

        private void volumen_ValueChanged(object sender, decimal value)
        {
            
                axWindowsMediaPlayer1.settings.volume = volumen.Value;
                labelvolumen.Text = axWindowsMediaPlayer1.settings.volume.ToString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                minutero.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                minutero.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                if (minutero.Value == minutero.Maximum)
                {
                    recorrer();
                }

            }


            try
            {
                minutero.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                time1.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            }
            catch
            {


            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            actualizadatostrack();
        }

        public void recorrer()
        {
            //Nodos_C p;
            if (nuevo != null)
            {
                nuevo = liscircular.firs.enlace; // siguiente nodo al de acceso
                                                           
                while (nuevo == liscircular.firs.enlace)
                {
                    if (CANCIONES.SelectedIndex < CANCIONES.Items.Count - 1)
                    {

                        CANCIONES.SelectedIndex += 1;

                        nuevo = nuevo.enlace;
                    }
                    else
                    {

                        axWindowsMediaPlayer1.URL = addpath.FileNames[0];
                        CANCIONES.SelectedIndex = 0;
                        nuevo = nuevo.enlace;
                    }

                    nuevo = nuevo.enlace;
                }
            }
            else
            {
                MessageBox.Show("\t LISTA CIRCULAR VACIA");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void time2_Click(object sender, EventArgs e)
        {

        }

        private void btnvolumen_Click(object sender, EventArgs e)
        {
            volumen.Visible = true;
        }

        private void volumen_MouseLeave(object sender, EventArgs e)
        {
            volumen.Visible = false;
        }

        private void time1_Click(object sender, EventArgs e)
        {

        }

        private void buttonaleatorio_Click(object sender, EventArgs e)
        {
            //if (CANCIONES.SelectedIndex < CANCIONES.Items.Count - 1)
            //{
            //    CANCIONES.SelectedIndex += 1;
            //}
            Random numero = new Random();
            int a = numero.Next(CANCIONES.Items.Count - 1);
            axWindowsMediaPlayer1.URL = addpath.FileNames[a];
            CANCIONES.SelectedIndex = a;
        }
    }
}
