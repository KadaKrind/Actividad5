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
using Actividad4.DAL;

namespace Actividad4.VISTA.VentasVista
{
    public partial class VentasListarVista : Form
    {
        public VentasListarVista()
        {
            InitializeComponent();
        }
        VentasDal vdal = new VentasDal();
        private void VentasListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vdal.ListarProductosParaAgregar();
            textBox1.Text = vdal.ObtenerUltimoIdVentaDal().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string consulta = "select * from Productos where IDProducto=" + IdProductoSeleccionado;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asas");
            textBox2.Text = tabla.Rows[0]["IDProducto"].ToString();
            textBox3.Text = tabla.Rows[0]["PrecioUnitario"].ToString();


            /*if (dataGridView1.SelectedRows.Count > 0) 
            {
                DataGridViewRow fila= dataGridView1.SelectedRows[0];
                string a = fila.Rows["IDProducto"].Value;
                textBox2 = fila.Cells["IDProducto"].Value;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún producto.");
            }*/
            // p.IDPedidos = Convert.ToInt32(tabla.Rows[0]["IDPedido"]);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                double a, z;
                a = Convert.ToInt32(numericUpDown1.Value);
                z = Convert.ToDouble(textBox3.Text);
                double c = a * z;
                textBox4.Text = c.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double a, z;
            a = Convert.ToInt32(numericUpDown1.Value);
            z = Convert.ToDouble(textBox3.Text);
            double c = a * z;
            textBox4.Text = c.ToString();

        }
        Ventas v=new Ventas();
        Detalleventas dv= new Detalleventas();  
        private void button1_Click(object sender, EventArgs e)
        {
            dv.IDVenta=Convert.ToInt32(textBox1.Text);
            v.FechaVenta = dateTimePicker1.Value;
            dv.IDProducto = Convert.ToInt32(textBox2.Text);
            dv.Cantidad = Convert.ToInt32(numericUpDown1.Value);
            dv.PrecioUnitario= Convert.ToDecimal(textBox3.Text);
            v.TotalVenta= Convert.ToDecimal(textBox4.Text);
            dv.TotalDetalle = Convert.ToDecimal(textBox4.Text);
            vdal.InsertarVentaDal(v);
            vdal.InsertarDetalleVentaDal(dv);
            MessageBox.Show("Se Guardo Correctamente");
            this.DialogResult = DialogResult.OK;    

        }
    }
}
