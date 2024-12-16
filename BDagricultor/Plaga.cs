using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDagricultor
{
    public class Plaga
    {
        public int idPlaga { get; set; }
        public string nombrePlaga { get; set; }
        public string tipoPlaga { get; set; }
        public string nivelDanio { get; set; }
        public int idCultivo { get; set; }

        public Plaga() { }

        public Plaga(int idPlaga, string nombrePlaga, string tipoPlaga, string nivelDanio, int idCultivo)
        {
            this.idPlaga = idPlaga;
            this.nombrePlaga = nombrePlaga;
            this.tipoPlaga = tipoPlaga;
            this.nivelDanio = nivelDanio;
            this.idCultivo = idCultivo;
        }
    }
}

