using Actividad4.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4.VISTA.PedidoVista
{
    public partial class ListarPedidoVista : Form
    {
        public ListarPedidoVista()
        {
            InitializeComponent();
        }
        PedidoBss bss = new PedidoBss();
        private void ListarPedidoVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPedidoBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdPedidoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditarPedidoVista fr = new EditarPedidoVista(IdPedidoSeleccionado);
            //this.Close();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPedidoBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarPedidoVista fr = new AgregarPedidoVista();
            
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPedidoBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idPedidoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta Seguro de eliminar este pedido", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPedidoBss(idPedidoSeleccionado);
                dataGridView1.DataSource= bss.ListarPedidoBss();
            }
           
            
        }
    }
}
