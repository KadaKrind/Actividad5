using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Actividad4.DAL;
using Actividad4.MODELOS;

namespace Actividad4.BSS
{
    public class PedidoBss
    {
        PedidoDal dal=new PedidoDal();

        public DataTable ListarPedidoBss()
        {
            return dal.ListarPedidoDal();
        }
        public void InsertarPedidoBss(Pedido pedido)
        {
            dal.InsertarPedidoDal(pedido);
        }
        public void EditarPedidoBss(Pedido p)
        {
            dal.EditarPedidoDal(p);
        }
        public Pedido ObtenerPedidoIdBss(int id) 
        {
            return dal.ObtenerPedidoId(id);
        }
        public void EliminarPedidoBss(int id)
        {
            dal.EliminarPedidoDal(id);
        }
        
    }
}
