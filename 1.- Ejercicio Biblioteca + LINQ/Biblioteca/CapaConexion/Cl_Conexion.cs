using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CapaConexion
{
    public class Cl_Conexion
    {
        private static SqlConnection cone;
        private string cadena = "Data Source=localhost\SQLEXPRESS; Initial Catalog=Libros; Persist Security Info=True; User ID=sa; Password=Duocadmin2016 "; 


        public Cl_Conexion(){
        
            if(cone == null){
                cone = new SqlConnection(cadena);
            }

        }


        //recupera el estado de la conexion
        public SqlConnection obtenerConexion(){

            return cone;
        }



    }
}
