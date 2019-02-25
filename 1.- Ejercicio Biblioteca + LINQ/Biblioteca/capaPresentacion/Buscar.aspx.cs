using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using capaLogicaNegocio;
using capaAccesoDatos;

namespace capaPresentacion
{
    public partial class Buscar : System.Web.UI.Page
    {
        DAOLibro dao;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["coleccion"] == null)
            {
                dao = new DAOLibro();
                Session["coleccion"] = dao;
            }
            else
            {

                dao = (DAOLibro)Session["coleccion"];
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //recuperamos la lista completa y la almacenamos en un objeto de tipo Lista
            List<Libro> lista = dao.listarTodos();
            //esta lista será nuestro origen de datos para el gridView
            gvListado.DataSource = lista;
            gvListado.DataBind();
        }
    }
}