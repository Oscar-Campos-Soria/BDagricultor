using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDagricultor
{
    public class Cultivo
    {
        public int idCultivo { get; set; }
        public string nombreCultivo { get; set; }
        public string temporada { get; set; }
        public int idAgricultor { get; set; }

        public Cultivo() { }
        public Cultivo(int idCultivo, string nombreCultivo, string temporada, int idAgricultor)
        {
            this.idCultivo = idCultivo;
            this.nombreCultivo = nombreCultivo;
            this.temporada = temporada;
            this.idAgricultor = idAgricultor;
        }
      
    }
}
