using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
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
        RegistroScreen screenManual;

        //constructor
        public PantallaPrincipal(){
            //default
            InitializeComponent();
            CenterToScreen();

            //inicializacion
            listaScreens = new List<RegistroScreen>();
            cantidadScreens = 0;
            screenManual = null;

            //configuracion
            this.Text = titulo;
            /***************************PRUBAS UNITARIAS****************************/
            
            this.Show();
            //damos tiempo para que se muestre la ventana
            Thread.Sleep(4000);
            //corremos las pruebas unitarias
            PruebasUnitarias test = new PruebasUnitarias(this);
            test.verificarPantallazos();
            

            /***************************FIN PRUEBAS UNITARIAS*******************************************/


        }

        public List<RegistroScreen> getListaScreens()
        {

            return listaScreens;

        }

        /*CAPTURAS AUTOMATICAS*/

        //boton iniciar
        private void btnCAIniciar_Click(object sender, EventArgs e)
        {
            int cantidad = (int)Decimal.Round(numCACantidad.Value, 0);
            int intervalo = (int)Decimal.Round(numCAIntervalo.Value * 1000, 0);
            int retardo = (int)Decimal.Round(numCARetardo.Value * 1000, 0);
            iniciar(cantidad, intervalo, retardo);
        }

        public void iniciar(int cantidad, int intervalo, int retardo)
        {

            //minimiza la ventana
            //this.WindowState = FormWindowState.Minimized;
            this.Hide();
            //retardo
            Thread.Sleep(retardo + 500);
            //hasta que cumpla la cantidad
            for (int i = 0; i < cantidad; i++)
            {
                //arma el nombre de archivo
                string nombreArchivo = String.Format("{0}{1}.{2}", "scr", ++cantidadScreens, "png");
                //string nombreArchivo = String.Format("{0}{1}", "scr", ++cantidadScreens);
                //toma captura
                capturar(nombreArchivo, pathProyecto);
                //retardo si no es la ultima
                if (i < cantidad - 1)
                {
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

        /*TOMAR CAPTURA*/

        //toma captura
        private RegistroScreen capturar( string nombreArchivo, string pathGuardado ){
            //crea un objeto para poner limites
            //Rectangle bounds = this.Bounds;
            Rectangle bounds = new Rectangle();
            //pide que se llene con la ventana activa
            leerDimensionVentanaActiva( ref bounds );
            //muestra dimensiones en consola
            //Console.WriteLine(String.Format("(x,y) = {0},{1}\t(width,height) = {2},{3}", bounds.X, bounds.Y, bounds.Width, bounds.Height));
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

        /*private RegistroScreen capturaManual(string nombreArchivo, string pathGuardado)
        {
            //crea un objeto para poner limites
            //Rectangle bounds = this.Bounds;
            Rectangle bounds = new Rectangle();
            //pide que se llene con la ventana activa
            leerDimensionVentanaActiva(ref bounds);
            //muestra dimensiones en consola
            //Console.WriteLine(String.Format("(x,y) = {0},{1}\t(width,height) = {2},{3}", bounds.X, bounds.Y, bounds.Width, bounds.Height));
            //crea una imagen
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
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
            //listaScreens.Add(rs);
            return rs;
        }*/

        //permite obtener la posicion de una ventana
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        //struct para mantener la posicion de una ventana
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        //permite obtener un handler de la ventana actual
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        //
        private void leerDimensionVentanaActiva( ref Rectangle bounds )
        {
            IntPtr hwnd = GetForegroundWindow();
            RECT rct;
            //if (!GetWindowRect(new HandleRef(this, this.Handle), out rct))
            if (!GetWindowRect(new HandleRef(this, hwnd), out rct))
            {
                MessageBox.Show("Error, no se detecto ventana", titulo,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bounds.X = rct.Left;
            bounds.Y = rct.Top;
            bounds.Width = rct.Right - rct.Left + 1;
            bounds.Height = rct.Bottom - rct.Top + 1;
            Console.WriteLine(String.Format("(x,y) = {0},{1}\t(width,height) = {2},{3}", bounds.X, bounds.Y, bounds.Width, bounds.Height));
        }

        /*CAPTURAS MANUALES*/

        private void btnCMTomar_Click(object sender, EventArgs e)
        {
            //tomar valores
            int retardo = (int)Decimal.Round(numCMRetardo.Value * 1000, 0);
            //oculta la ventana
            this.Hide();
            //retardo
            Thread.Sleep(retardo + 500);
            //arma el nombre de archivo
            string nombreArchivo = String.Format("{0}{1}.{2}", "scr", ++cantidadScreens, "png");
            //toma captura
            screenManual = capturar(nombreArchivo, pathProyecto);
            //pide informacion
            DescripcionCM descripcion = new DescripcionCM(this);
        }

        //establece informacion de captura
        public void setInfoCM( String titulo, String descripcion ) {
            //asigna inforamacion
            screenManual.nombre = titulo;
            screenManual.descripcion = descripcion;
            //listaScreens.Add( screenManual );
            //prueba
            recorrerLista();
            //borra referencia
            screenManual = null;
        }

        //prueba para mostrar la lista
        public void recorrerLista() {
            for (int i = 0; i < listaScreens.Count(); i++) {
                MessageBox.Show(listaScreens.ElementAt(i).nombre, "Titulo",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                Debug.WriteLine(listaScreens.ElementAt(i).nombre);
            }
        }

    }
}
