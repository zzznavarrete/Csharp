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
    public partial class Modificar : System.Web.UI.Page
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
            
            
            //dejamos solo habilitado el codigo para buscar, si no ha habido un post back
            //con esto evitamos que no se blooquen los botones si presiono un boton por equivocación
            if (!IsPostBack)
            {
                
                bloquearBotones();
            }
        }


        private void bloquearBotones() {
            txtTitulo.Enabled = false;
            txtAutor.Enabled = false;
            txtEditorial.Enabled = false;
            txtAnnioPublicacion.Enabled = false;
            txtPrecio.Enabled = false;
            chkPrestamo.Enabled = false;
            btnModificar.Enabled = false;
            //habilitamos el codigo para buscar el libro
            txtCodigo.Enabled = true;
            
        }

        private void desbloquearBotones()
        {
            txtTitulo.Enabled = true;
            txtAutor.Enabled = true;
            txtEditorial.Enabled = true;
            txtAnnioPublicacion.Enabled = true;
            txtPrecio.Enabled = true;
            chkPrestamo.Enabled = true; //que esté disponible
            btnModificar.Enabled = true;
            //desabilitamos el codigo para que no sea editado
            txtCodigo.Enabled = false;
            
        }

        private void limpiar() {
            txtTitulo.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtEditorial.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtAnnioPublicacion.Text = string.Empty;
            chkPrestamo.Checked = false;
        
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //Los botones están deshabilitados excepto el codigo
            //recuperamos el codigo y buscamos el libro
            Libro libro = dao.buscarLibro(int.Parse(txtCodigo.Text));
            
            //habilitamos los botones
            desbloquearBotones();
            
            //cargamos los datos en los TextBox
            txtTitulo.Text = libro.Titulo;
            txtAutor.Text = libro.Autor;
            txtEditorial.Text = libro.Editorial;
            txtAnnioPublicacion.Text = libro.AnnioPublicacion.ToString();
            txtPrecio.Text = libro.Precio.ToString();
            chkPrestamo.Checked = libro.EnPrestamo;

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //creo el objeto Libro con datos nuevos
                Libro libro = new Libro();

                libro.Codigo = int.Parse(txtCodigo.Text);
                libro.Titulo = txtTitulo.Text;
                libro.Editorial = txtEditorial.Text;
                libro.Autor = txtAutor.Text;
                libro.AnnioPublicacion = int.Parse(txtAnnioPublicacion.Text);
                libro.Precio = int.Parse(txtPrecio.Text);
                libro.EnPrestamo = chkPrestamo.Checked;

                
                bool respuesta = dao.modificarLibro(libro);
                if (respuesta == true)
                {
                    lblMensaje.Text = "Libro Modificado";
                    //limpio los campos
                    limpiar();
                    //vuelvo a habilitar el textBox para el codigo y bloqueo el resto
                    bloquearBotones();
                }
                else
                {
                    lblMensaje.Text = "No se pudo modificar el libro";

                }
                
            }catch(Exception  error){
                lblMensaje.Text = error.Message;
            }

        }
    }
}