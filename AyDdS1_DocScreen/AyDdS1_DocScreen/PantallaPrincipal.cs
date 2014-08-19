using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyDdS1_DocScreen
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCAIniciar_Click(object sender, EventArgs e)
        {
            //toma valores
            int cantidad = (int) Decimal.Round(numCACantidad.Value, 0);
            int intervalo = (int) Decimal.Round(numCAIntervalo.Value * 1000, 0);
            int retardo = (int) Decimal.Round(numCARetardo.Value, 0);

        }

        private void numCARetardo_ValueChanged(object sender, EventArgs e)
        {

        }



    }
}
