using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta_Andro.Formularios.Caja
{
    public partial class Apertura_Caja : Form
    {
        public Apertura_Caja()
        {
            InitializeComponent();
        }

        private void BtnApertura_Click(object sender, EventArgs e)
        {
            this.Hide();

            Caja_Principal Caja_P = new Caja_Principal();
            Caja_P.Show();
        }
    }
}
