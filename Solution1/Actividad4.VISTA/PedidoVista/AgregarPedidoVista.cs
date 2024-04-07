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
using Actividad4.MODELOS;

namespace Actividad4.VISTA.PedidoVista
{
    public partial class AgregarPedidoVista : Form
    {
        public AgregarPedidoVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        PedidoBss pbss = new PedidoBss();

        private void AgregarPedidoVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idcliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textBox2.Text = idcliente.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pedido p = new Pedido();
            p.IdPedido = Convert.ToInt32(textBox2.Text);
            p.Fecha = dateTimePicker1.Value;
            p.Total = Convert.ToInt32(textBox1.Text);
            pbss.InsertarPedidoBss(p);
            MessageBox.Show("Se guardo correctamente");
            //this.Close();
            //ListarPedidoVista fr = new ListarPedidoVista();
            //fr.Show();
            this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
