using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Actividad4.DAL;
using Actividad4.MODELOS;

namespace Actividad4.BSS
{
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienteDal();

        }
        public void AgregarClienteBss(Cliente cliente)
        {
            dal.AgregarClienteDal(cliente);
        }
        public Cliente ObtenerClientePorIdBss(int idCliente)
        {
            return dal.ObtenerClientePorIdDal(idCliente);
        }
        public void EditarClienteBss(Cliente cliente)
        {
            dal.EditarClienteDal(cliente);
        }
        public int ObtenerUltimoClienteIdBss()
        {
            return dal.ObtenerUltimoClienteIdDal();
        }
        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
    }
}
