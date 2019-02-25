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
    public partial class Eliminar : System.Web.UI.Page
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

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //del objeto dao enviamos el codigo del libro
                bool respuesta = dao.eliminarLibro(int.Parse(txtCodigo.Text));
                if (respuesta)
                {
                    lblMensaje.Text = "Libro Eliminado";
                }
                else
                {
                    lblMensaje.Text = "No se pudo eliminar el libro";
                }

            }catch(Exception error){
                //cargamos el mensaje si existe algun dato no controlado
                lblMensaje.Text = error.Message;
            }
        }
    }
}