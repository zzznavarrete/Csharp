using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaConexion;

using capaAccesoDatos;
using System.Data.SqlClient;

namespace capaLogicaNegocio
{
    public class DAOLibro : ILibro
    {
        private Cl_Operacion operacion;

        public DAOLibro()
        {
            operacion = new Cl_Operacion();
        }


        public bool agregar(Libro nuevoLibro)
        {
            try
            {
                String sql = "INSERT INTO LIBROS VALUES (@CODIGO, '@TITULO', '@AUTOR', '@EDITORIAL', @ANNIOPUBLICACION, @PRECIO, '@ENPRESTAMO')";
                sql = sql.Replace("@CODIGO", nuevoLibro.Codigo.ToString());
                sql = sql.Replace("@TITULO", nuevoLibro.Titulo);
                sql = sql.Replace("@AUTOR", nuevoLibro.Autor);
                sql = sql.Replace("@EDITORIAL", nuevoLibro.Editorial);
                sql = sql.Replace("@ANNIOPUBLICACION", nuevoLibro.AnnioPublicacion.ToString());
                sql = sql.Replace("@PRECIO", nuevoLibro.Precio.ToString());
                sql = sql.Replace("@ENPRESTAMO", nuevoLibro.EnPrestamo.ToString());

                int resultado = operacion.sqlOperacion(sql);
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }


            
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }


        }//llave final método







        //consulta select 
        public List<Libro> listarLibros()
        {
            try
            {
                String sql = "SELECT * FROM Libros";
                SqlDataReader dr = operacion.sqlSelection(sql);

                List<Libro> lista = new List<Libro>();
                //mientras el dr pueda leer datos
                while(dr.Read()){
                    Libro libroNuevo = new Libro();
                    libroNuevo.Codigo = (int)dr["codigo"];
                    libroNuevo.Titulo = dr["titulo"].ToString();
                    libroNuevo.Autor = dr["autor"].ToString();
                    libroNuevo.Editorial = dr["editorial"].ToString();
                    libroNuevo.AnnioPublicacion= (int)dr["AnnioPublicacion"];
                    libroNuevo.Precio= (int)dr["precio"];
                    libroNuevo.EnPrestamo = (bool)dr["EnPrestamo"];
                    lista.Add(libroNuevo);

                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }











    }
}
