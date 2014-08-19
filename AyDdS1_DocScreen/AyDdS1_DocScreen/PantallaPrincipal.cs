using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyDdS1_DocScreen
{
    public partial class PantallaPrincipal : Form
    {
        //atributos
        string titulo = "DocScreen";
        string pathProyecto = "C:\\AyDdS1\\Screenshots\\";
        List<RegistroScreen> listaScreens;
        int cantidadScreens;

        //constructor
        public PantallaPrincipal(){
            //default
            InitializeComponent();

            //inicializacion
            listaScreens = new List<RegistroScreen>();
            cantidadScreens = 0;

            //configuracion
            this.Text = titulo;
        }

        /*CAPTURAS AUTOMATICAS*/
        //boton iniciar
        private void btnCAIniciar_Click(object sender, EventArgs e)
        {
            //toma valores
            int cantidad = (int) Decimal.Round(numCACantidad.Value, 0);
            int intervalo = (int) Decimal.Round(numCAIntervalo.Value * 1000, 0);
            int retardo = (int) Decimal.Round(numCARetardo.Value*1000, 0);
            //minimiza la ventana
            //this.WindowState = FormWindowState.Minimized;
            this.Hide();
            //retardo
            Thread.Sleep(retardo + 500);
            //hasta que cumpla la cantidad
            for (int i = 0; i < cantidad; i++){
                //arma el nombre de archivo
                string nombreArchivo = String.Format("{0}{1}.{2}", "scr", ++cantidadScreens, "png");
                //string nombreArchivo = String.Format("{0}{1}", "scr", ++cantidadScreens);
                //toma captura
                capturar(nombreArchivo, pathProyecto);
                //retardo si no es la ultima
                if (i<cantidad-1){
                    Thread.Sleep(intervalo);
                }
            }
            //regresar la ventana
            //his.WindowState = FormWindowState.Normal;
            this.Show();
            //muestar mensaje
            MessageBox.Show("Capturas tomadas con exito", titulo, 
                MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        //toma captura
        private RegistroScreen capturar( string nombreArchivo, string pathGuardado ){
            //crea un objeto para poner limites
            Rectangle bounds = this.Bounds;
            //crea una imagen
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height)){
                using (Graphics g = Graphics.FromImage(bitmap)){
                    //toma la captura
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                //arma el nombre absoluto
                string nombreAbsoluto = String.Format("{0}{1}", pathGuardado, nombreArchivo);
                //guarda el archivo
                bitmap.Save(nombreAbsoluto, ImageFormat.Png);
            }
            //crea objeto de registro
            RegistroScreen rs = new RegistroScreen(nombreArchivo, pathGuardado);
            //lo añade a la lista del proyecto
            listaScreens.Add(rs);
            return rs;
        }

        /*CAPTURAS MANUALES*/
        private void numCARetardo_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
