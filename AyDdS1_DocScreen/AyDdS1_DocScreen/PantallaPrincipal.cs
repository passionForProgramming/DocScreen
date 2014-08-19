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
        string pathProyecto;
        List<RegistroScreen> listaScreens;
        int cantidadScreens;

        //constructor
        public PantallaPrincipal(){
            //default
            InitializeComponent();

            //inicializacion
            pathProyecto = "C:\\AyDdS1\\Screenshots\\";
            listaScreens = new List<RegistroScreen>();
            cantidadScreens = 0;
        }

        /*CAPTURAS AUTOMATICAS*/
        //boton iniciar
        private void btnCAIniciar_Click(object sender, EventArgs e)
        {
            //toma valores
            int cantidad = (int) Decimal.Round(numCACantidad.Value, 0);
            int intervalo = (int) Decimal.Round(numCAIntervalo.Value * 1000, 0);
            int retardo = (int) Decimal.Round(numCARetardo.Value*1000, 0);
            //retardo
            Thread.Sleep( retardo );
            //minimiza la ventana
            this.WindowState = FormWindowState.Minimized;
            //hasta que cumpla la cantidad
            for (int i = 0; i < cantidad; i++){
                //arma el nombre
                string nombreAbsoluto = String.Format("{0}{1}{2}.{3}", pathProyecto, "scr", ++cantidadScreens, ".png");
                //toma captura
                capturar(nombreAbsoluto);
                //retardo si no es la ultima
                if (i<cantidad-1){
                    Thread.Sleep(intervalo);
                }
            }
            //regresar la pantalla
            this.WindowState = FormWindowState.Normal;
        }

        //toma captura
        private void capturar( string pathGuardado ){
            //crea un objeto para poner limites
            Rectangle bounds = this.Bounds;
            //crea una imagen
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height)){
                using (Graphics g = Graphics.FromImage(bitmap)){
                    //toma la captura
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                //guarda el archivo
                //bitmap.Save("C:\\AyDdS1\\Screenshots\\btn2.png", ImageFormat.Jpeg);
                bitmap.Save(pathGuardado, ImageFormat.Png);
            }
        }

        /*CAPTURAS MANUALES*/
        private void numCARetardo_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
