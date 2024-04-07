using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad4.DAL;

namespace Actividad4.VISTA.VentasVista
{
    public partial class ListarDetalleVentasVista : Form
    {
        public ListarDetalleVentasVista()
        {
            InitializeComponent();
        }
        VentasDal vdal=new VentasDal();
        private void ListarDetalleVentasVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vdal.ListarDetalleVentasDal();
        }
    }
}
