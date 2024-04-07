using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Actividad4.MODELOS;

namespace Actividad4.DAL
{
    public class VentasDal
    {
        public DataTable ListarVentasDal()
        {
            string consulta = "select * from Ventas";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarDetalleVentasDal()
        {
            string consulta = "select * from DetalleVenta";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarProductosParaAgregar()
        {
            string consulta = "SELECT IDProducto, NombreProducto, PrecioUnitario\r\nFROM   Productos";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarVentaDal(Ventas venta)
        {
            string consulta = "INSERT INTO Ventas (FechaVenta, TotalVenta) VALUES ('" + venta.FechaVenta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + venta.TotalVenta.ToString("0.00") + ")";
            conexion.Ejecutar(consulta);
        }
        public void InsertarDetalleVentaDal(Detalleventas detalleVenta)
        {
            string consulta = "INSERT INTO DetalleVenta (IDVenta, IDProducto, Cantidad, PrecioUnitario, TotalDetalle) " +
                              "VALUES (" + detalleVenta.IDVenta + ", " + detalleVenta.IDProducto + ", " +
                              detalleVenta.Cantidad + ", " + detalleVenta.PrecioUnitario.ToString("0.00") + ", " +
                              detalleVenta.TotalDetalle.ToString("0.00") + ")";
            conexion.Ejecutar(consulta);
        }
        public int ObtenerUltimoIdVentaDal()
        {
            string consulta = "SELECT MAX(IDVenta) FROM Ventas";
            int ultimoId = Convert.ToInt32(conexion.EjecutarEscalarComoString(consulta));
            return ultimoId + 1;
        }



    }
}
