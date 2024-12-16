using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDagricultor
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }

        public Proveedor() { }

        public Proveedor(int idProveedor, string nombreProveedor, string telefono, string direccion)
        {
            this.idProveedor = idProveedor;
            this.nombreProveedor = nombreProveedor;
            this.telefono = telefono;
            this.direccion = direccion;
        }
    }
}

