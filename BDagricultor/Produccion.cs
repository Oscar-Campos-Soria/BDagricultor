using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDagricultor
{
    public class Produccion
    {
        public int idProduccion { get; set; }
        public decimal cantidad { get; set; }
        public string calidad { get; set; }
        public DateTime fechaProduccion { get; set; }
        public int idCultivo { get; set; }

        public Produccion() { }

        public Produccion(int idProduccion, decimal cantidad, string calidad, DateTime fechaProduccion, int idCultivo)
        {
            this.idProduccion = idProduccion;
            this.cantidad = cantidad;
            this.calidad = calidad;
            this.fechaProduccion = fechaProduccion;
            this.idCultivo = idCultivo;
        }
    }
}

