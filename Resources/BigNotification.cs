using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta_Andro.Resources
{
    public partial class BigNotification : Form
    {
        public BigNotification()
        {
            InitializeComponent();
        }

        private void TimerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BigNotification_Load(object sender, EventArgs e)
        {
            TimerClose.Start();
        }
    }
}
