using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using Cargar_Remitos;


namespace Datos
{
    public class Conexion
    {

        //public SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-O9U7H5K3;Initial Catalog=CargarRemito;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlConnection conexion;
        public string cadenaConexion = @"Data Source=DESKTOP-TPN7G35;Initial Catalog=CargarRemito;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Conexion()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        // Y los métodos para abrir y cerrar la Conexión
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);


            }
        }

        


    }
}