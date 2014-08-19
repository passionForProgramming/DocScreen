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
            InitializeComponent();
            this.pantalla = pantalla;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla.setInfo(txtTituloCM.Text, txtDescripcionCM.Text);
            pantalla.Show();

        }

    }
}
