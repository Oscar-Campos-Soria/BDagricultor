using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDagricultor
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public Cliente() { }

        public Cliente(int idCliente, string nombreCliente, string direccion, string telefono)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.direccion = direccion;
            this.telefono = telefono;
        }
    }
}

