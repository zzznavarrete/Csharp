using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using capaLogicaNegocio;
namespace capaPresentacion
{
    public partial class Listar : System.Web.UI.Page
    {
        //variable global
        DAOLibro dao;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["coleccion"] != null)
            {
                dao = (DAOLibro)Session["coleccion"];
                gvListado.DataSource = dao.listarTodos();
                gvListado.DataBind();
            }
            else {
                Response.Write("Lista Vacia");
            }
        }
    }
}