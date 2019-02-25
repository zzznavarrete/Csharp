using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using capaAccesoDatos;
using capaLogicaNegocio;

namespace capaPresentacion
{
    public partial class Agregar : System.Web.UI.Page
    {
        DAOLibro dao;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["coleccion"] == null)
            {
                dao = new DAOLibro();
                Session["coleccion"] = dao;
            }
            else {

                dao = (DAOLibro)Session["coleccion"];
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Libro libro = new Libro();
                libro.Codigo = int.Parse(txtCodigo.Text);
                //libro.Codigo = Convert.ToInt32(txtCodigo.Text);
                libro.Titulo = txtTitulo.Text;
                libro.Autor = txtAutor.Text;
                libro.Editorial = txtEditorial.Text;
                libro.AnnioPublicacion = int.Parse(txtAnnioPublicacion.Text);
                libro.Precio = int.Parse(txtPrecio.Text);
                libro.EnPrestamo = chkPrestamo.Checked;

               
                bool respuesta = dao.agregar(libro);
                if (respuesta == true)
                {
                    lblMensaje.Text = "Libro almacenado";
                }
                else
                {
                    lblMensaje.Text = "El libro ya existe";
                }

            }catch(Exception error){
                lblMensaje.Text = error.Message;
            }

        }
    }
}