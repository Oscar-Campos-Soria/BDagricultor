using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDagricultor
{
    public class BDAgricultor
    {

        public static SqlConnection obtenerconexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=BDagricultor;Data Source=Oscar");
            conexion.Open();
            return conexion;

        }



    }
}
