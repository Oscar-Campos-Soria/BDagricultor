using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDagricultor
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public DateTime fechaPedido { get; set; }
        public decimal cantidad { get; set; }
        public int idProveedor { get; set; }

        public Pedido() { }

        public Pedido(int idPedido, DateTime fechaPedido, decimal cantidad, int idProveedor)
        {
            this.idPedido = idPedido;
            this.fechaPedido = fechaPedido;
            this.cantidad = cantidad;
            this.idProveedor = idProveedor;
        }
    }
}

