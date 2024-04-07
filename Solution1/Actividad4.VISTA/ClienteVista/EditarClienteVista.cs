using Actividad4.DAL;
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
using Actividad4.BSS;

namespace Actividad4.VISTA.ClienteVista
{
    public partial class EditarClienteVista : Form
    {
        int idx = 0;
        ClienteDal cdal = new ClienteDal();
        Cliente c = new Cliente();
        ClienteBss cbss=new ClienteBss();
        public EditarClienteVista(int id)
        {
            idx = id;
            InitializeComponent();



        }

        private void EditarClienteVista_Load(object sender, EventArgs e)
        {
            c = cbss.ObtenerClientePorIdBss(idx);
            textBox1.Text = c.IDCliente.ToString();
            textBox2.Text = c.Nombre;
            textBox3.Text = c.Apellido;
            textBox4.Text = c.CorreoElectronico;
            textBox5.Text = c.Telefono.ToString();
            textBox6.Text = c.Direccion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.IDCliente=Convert.ToInt32(textBox1.Text);
            c.Nombre=textBox2.Text;
            c.Apellido=textBox3.Text;
            c.CorreoElectronico=textBox4.Text;
            c.Telefono=Convert.ToInt32(textBox5.Text);
            c.Direccion=textBox6.Text;
            cbss.EditarClienteBss(c);
            MessageBox.Show("Editado Correctamente");
            this.DialogResult=DialogResult.OK;
        }
    }
}
