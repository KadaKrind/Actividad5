using Actividad4.BSS;
using Actividad4.VISTA.PedidoVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4.VISTA.ClienteVista
{
    public partial class ClienteListarVista : Form
    {
        public ClienteListarVista()
        {
            InitializeComponent();
        }
        ClienteBss cbss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            ClienteAgregarVista fr = new ClienteAgregarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = cbss.ListarClienteBss();
            }
        }

        private void ClienteListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cbss.ListarClienteBss();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditarClienteVista fr = new EditarClienteVista(IdClienteSeleccionado);
            //this.Close();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = cbss.ListarClienteBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta Seguro de eliminar este pedido", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cbss.EliminarClienteBss(idClienteSeleccionado);
                dataGridView1.DataSource = cbss.ListarClienteBss();
            }
        }
    }
}
