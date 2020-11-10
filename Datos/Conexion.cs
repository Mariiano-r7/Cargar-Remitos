using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;

namespace Datos
{
    public class Conexion
    {

        public SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-O9U7H5K3;Initial Catalog=CargarRemito;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    }
}
