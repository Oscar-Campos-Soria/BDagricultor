using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDagricultor
{
    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string experiencia { get; set; }



        public Persona() { }
        public Persona(int id, string nombre, int edad, string experiencia)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.experiencia = experiencia;
        }
    }
}
