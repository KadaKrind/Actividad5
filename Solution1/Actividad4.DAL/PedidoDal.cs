using Actividad4.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Actividad4.DAL
{
    public class PedidoDal
    {
        public DataTable ListarPedidoDal()
        {
            string consulta = "select * from Pedido";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarPedidoDal(Pedido pedido)
        {
            string consulta = "insert into Pedido values('" + pedido.IdPedido + "'," + "'" + pedido.Fecha + "'," + "'" + pedido.Total + "'," + "'completado')";
            conexion.Ejecutar(consulta);    
        }
        public void EditarPedidoDal(Pedido p)
        {

            /*string consulta = "UPDATE Pedido SET Fecha = '" + p.Fecha + "', Total = '" + p.Total + "', Estado = 'completado' WHERE IDPedido = " + p.IdPedidos;
            conexion.Ejecutar(consulta);*/
            string consulta = "UPDATE Pedido SET IdCliente = '" + p.IdPedido + "', Fecha = '" + p.Fecha + "', Total = '" + p.Total + "', Estado = 'completado' WHERE IdPedido = " + p.IDPedidos;
            conexion.Ejecutar(consulta);
             


        }
        public Pedido ObtenerPedidoId(int id)
        {
            string consulta = "select * from Pedido where IDPedido=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asas");
            Pedido p=new Pedido();
            if (tabla.Rows.Count > 0)
            {
                p.IDPedidos = Convert.ToInt32(tabla.Rows[0]["IDPedido"]);
                p.Total = Convert.ToInt32(tabla.Rows[0]["Total"]);
                object fechaDB = tabla.Rows[0]["Fecha"];
                p.IdPedido = Convert.ToInt32(tabla.Rows[0]["IdCliente"]);
                if (fechaDB != DBNull.Value)
                {
                    p.Fecha = Convert.ToDateTime(fechaDB);
                }
                else
                {
                    p.Fecha = DateTime.MinValue;
                }

            }
            return p;
            }
        public void EliminarPedidoDal(int id)
        {
            string consulta = "delete from Pedido where IDPedido=" + id;
            conexion.Ejecutar(consulta);
        }

    }
}
