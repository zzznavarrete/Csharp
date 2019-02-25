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
    public partial class Estadisticas : System.Web.UI.Page
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

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            lblCantidad.Text = dao.cantidadLibros(int.Parse(txtAnnio.Text)).ToString();
        }

        protected void btnPromedio_Click(object sender, EventArgs e)
        {
            try
            {
                lblPromedio.Text = dao.promedioPrecios().ToString();
            }
            catch (Exception ex)
            {
                lblPromedio.Text = ex.Message;
            }
        }

        protected void btnLibrosAutor_Click(object sender, EventArgs e)
        {
            try
            {
                lblLibrosAutor.Text = dao.librosPorAutor(txtLibrosAutor.Text).ToString();
            }
            catch (Exception ex)
            {
                lblPromedio.Text = ex.Message;
            }
        }
    }
}