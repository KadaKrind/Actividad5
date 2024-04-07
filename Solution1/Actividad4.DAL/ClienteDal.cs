using Actividad4.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from Cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void AgregarClienteDal(Cliente cliente)
        {
            string consulta = "INSERT INTO Cliente (Nombre, Apellido, CorreoElectronico, Telefono, Direccion) VALUES ('" +
                              cliente.Nombre + "', '" + cliente.Apellido + "', '" + cliente.CorreoElectronico + "', '" +
                              cliente.Telefono + "', '" + cliente.Direccion + "')";
            conexion.Ejecutar(consulta);
        }
        public Cliente ObtenerClientePorIdDal(int idCliente)
        {
            string consulta = "SELECT * FROM Cliente WHERE IDCliente = " + idCliente;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "cliente");

            Cliente cliente = null;

            if (tabla.Rows.Count > 0)
            {
                cliente = new Cliente
                {
                    IDCliente = Convert.ToInt32(tabla.Rows[0]["IDCliente"]),
                    Nombre = tabla.Rows[0]["Nombre"].ToString(),
                    Apellido = tabla.Rows[0]["Apellido"].ToString(),
                    CorreoElectronico = tabla.Rows[0]["CorreoElectronico"].ToString(),
                    Telefono = Convert.ToInt32(tabla.Rows[0]["Telefono"]),
                    Direccion = tabla.Rows[0]["Direccion"].ToString()
                };
            }

            return cliente;
        }
        public void EditarClienteDal(Cliente cliente)
        {
            string consulta = "UPDATE Cliente SET " +
                              "Nombre = '" + cliente.Nombre + "', " +
                              "Apellido = '" + cliente.Apellido + "', " +
                              "CorreoElectronico = '" + cliente.CorreoElectronico + "', " +
                              "Telefono = '" + cliente.Telefono + "', " +
                              "Direccion = '" + cliente.Direccion + "' " +
                              "WHERE IDCliente = " + cliente.IDCliente;

            conexion.Ejecutar(consulta);
        }
        public int ObtenerUltimoClienteIdDal()
        {
            string consulta = "SELECT MAX(IDCliente) FROM Cliente";
            int ultimoId = Convert.ToInt32(conexion.EjecutarEscalar(consulta));
            return ultimoId + 1;
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from Cliente where IDCliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
