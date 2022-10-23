using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;

namespace pj_w6_Mantenimiento_sql_csharp
{
    internal class Conexion
    {
        //Metodo de conexion 
        public SqlConnection getConecta()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager
                                          .ConnectionStrings["cn"].ConnectionString);
            return cn;
        }
    }
}
