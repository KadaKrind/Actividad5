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

namespace Actividad4.VISTA.ClienteVista
{
    public partial class ClienteAgregarVista : Form
    {
        public ClienteAgregarVista()
        {
            InitializeComponent();
        }
        ClienteDal cdal = new ClienteDal();
        private void ClienteAgregarVista_Load(object sender, EventArgs e)
        {
            int a = 0;
            a = cdal.ObtenerUltimoClienteIdDal();
            textBox1.Text = a.ToString();
        }
        Cliente c = new Cliente();
        private void button1_Click(object sender, EventArgs e)
        {
            c.Nombre=textBox2.Text;
            c.Apellido=textBox3.Text;
            c.CorreoElectronico=textBox4.Text;
            c.Telefono=Convert.ToInt32(textBox5.Text);
            c.Direccion=textBox6.Text;  
            cdal.AgregarClienteDal(c);
            MessageBox.Show("Se guardo correctamente");
            this.DialogResult= DialogResult.OK;
        }
    }
}
