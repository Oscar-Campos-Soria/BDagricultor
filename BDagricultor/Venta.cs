using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDagricultor
{
    public class Venta
    {
        public int idVenta { get; set; }
        public DateTime fechaVenta { get; set; }
        public decimal cantidadVendida { get; set; }
        public decimal precioUnitario { get; set; }
        public int idProduccion { get; set; }
        public int idCliente { get; set; }

        public Venta() { }

        public Venta(int idVenta, DateTime fechaVenta, decimal cantidadVendida, decimal precioUnitario, int idProduccion, int idCliente)
        {
            this.idVenta = idVenta;
            this.fechaVenta = fechaVenta;
            this.cantidadVendida = cantidadVendida;
            this.precioUnitario = precioUnitario;
            this.idProduccion = idProduccion;
            this.idCliente = idCliente;
        }
    }
}

