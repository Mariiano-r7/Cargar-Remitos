using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosRemit : Conexion
    {
        public DataTable consultanombre()
        {
            conexion.Open();

            string query = "select Nombres from Personas, Domicilio, Proveedores" +
                "where Domicilio.Id_Domicilio = Proveedores.Id_Domicilio and Personas.Id_Domicilio = Proveedores.Id_Domicilio" +
                "and Proveedores.Id_Proveedor = @Id_Proveedor";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader reg = cmd.ExecuteReader();
            

            if (reg.Read())
            {
               return reg["Nombres"].ToString();


            }
            else
            {
                return "Null";
            }
            conexion.Close();
        }

    }
}
