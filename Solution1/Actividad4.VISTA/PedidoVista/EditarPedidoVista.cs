using Actividad4.BSS;
using Actividad4.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4.VISTA.PedidoVista
{
    public partial class EditarPedidoVista : Form
    {
        int idx = 0;
        Pedido p = new Pedido();
        public EditarPedidoVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        PedidoBss pbss = new PedidoBss();

        private void EditarPedidoVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
            //string a = p.Fecha.ToString();  
            //MessageBox.Show("{0}", a);
            p = pbss.ObtenerPedidoIdBss(idx);
            textBox1.Text = p.Total.ToString();
            DateTime fechaDB = p.Fecha;
            string fechaFormateada = fechaDB.ToString("yyyy-MM-dd HH:mm:ss");
            dateTimePicker1.Value = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            textBox2.Text = p.IdPedido.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idcliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textBox2.Text = idcliente.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Fecha = dateTimePicker1.Value;
            p.Total=Convert.ToInt32(textBox1.Text);
            p.IdPedido = Convert.ToInt32(textBox2.Text);
            pbss.EditarPedidoBss(p);
            MessageBox.Show("Datos Actualizados");
            this.DialogResult = DialogResult.OK;
        }
    }
}
