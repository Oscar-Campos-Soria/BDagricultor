using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDagricultor
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string puesto { get; set; }
        public decimal salario { get; set; }
        public int idAgricultor { get; set; }

        public Empleado() { }

        public Empleado(int idEmpleado, string nombreEmpleado, string puesto, decimal salario, int idAgricultor)
        {
            this.idEmpleado = idEmpleado;
            this.nombreEmpleado = nombreEmpleado;
            this.puesto = puesto;
            this.salario = salario;
            this.idAgricultor = idAgricultor;
        }
    }
}

