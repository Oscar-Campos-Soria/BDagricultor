using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDagricultor
{
    public class Gasto
    {
        public int idGasto { get; set; }
        public string descripcion { get; set; }
        public decimal monto { get; set; }
        public DateTime fechaGasto { get; set; }
        public int idCultivo { get; set; }

        public Gasto() { }

        public Gasto(int idGasto, string descripcion, decimal monto, DateTime fechaGasto, int idCultivo)
        {
            this.idGasto = idGasto;
            this.descripcion = descripcion;
            this.monto = monto;
            this.fechaGasto = fechaGasto;
            this.idCultivo = idCultivo;
        }
    }
}

