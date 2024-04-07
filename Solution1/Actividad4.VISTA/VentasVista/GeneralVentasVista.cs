using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4.VISTA.VentasVista
{
    public partial class GeneralVentasVista : Form
    {
        public GeneralVentasVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentasListarVista fr = new VentasListarVista();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListarVentasVista fr = new ListarVentasVista();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListarDetalleVentasVista fr = new ListarDetalleVentasVista();
            fr.Show();
        }
    }
}
