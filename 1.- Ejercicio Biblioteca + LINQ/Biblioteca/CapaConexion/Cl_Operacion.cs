using System.Data.SqlClient;
using System;
+using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaConexion
{
    public class Cl_Operacion
    {
        //creo una variable que recupera la conexion
        private SqlConnection cone;

        public Cl_Operacion(){
            cone = new Cl_Conexion().obtenerConexion();

        }

        //insertar, eliminar, actualizar
        public int sqlOperacion(String sql){
            try{
            SqlCommand cmd = new SqlCommand();
            cone.Open();
            int respuesta = cmd.ExecuteNonQuery(); //filas afectadas
            cone.Close();
            return respuesta;
            }catch(Exception ex){
                cone.Close();
                throw new Exception ("Error al ejecutar la consulta " + ex.Message); 
            }
        }


        //buscar
        public SqlDataReader sqlSelection(String sql){

            try{
                SqlCommand cmd = new SqlCommand(sql, cone);
                cone.Open();
                SqlDataReader dr = cmd.ExecuteReader(); // retorna el o los objetos
                cone.Close();
                return dr;
            }catch(Exception ex){
                cone.Close();
                throw new Exception("Error al ejecutar el select " + ex.Message);
            }


        }






    }
}
