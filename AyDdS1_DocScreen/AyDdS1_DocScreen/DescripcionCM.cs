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
    public partial class DescripcionCM : Form
    {
        PantallaPrincipal pantalla;
        public DescripcionCM(PantallaPrincipal pantalla)
        {
            //default
            InitializeComponent();
            CenterToParent();
            Show();
            
            //toma referencia de pantalla principal
            this.pantalla = pantalla;
        }

        private void btnCMDescGuardar_Click(object sender, EventArgs e)
        {
            //oculta la pantalla
            this.Hide();
            //guarda informacion
            pantalla.setInfoCM(txtTituloCM.Text, txtDescripcionCM.Text);
            //muestra la pantalla principal
            pantalla.Show();
            //libera memoria
            Dispose();
        }

    }
}
