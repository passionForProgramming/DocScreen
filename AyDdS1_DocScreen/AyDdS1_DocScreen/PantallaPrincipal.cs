using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        //constructor
        public PantallaPrincipal(){
            InitializeComponent();
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
                capturar();
            }
        }

        private void capturar()
        {

        }

        /*CAPTURAS MANUALES*/
        private void numCARetardo_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
