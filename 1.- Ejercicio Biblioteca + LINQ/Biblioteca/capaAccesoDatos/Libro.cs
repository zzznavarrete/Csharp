using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaAccesoDatos
{
    public class Libro
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        private string autor;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        private string editorial;

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }
        private int annioPublicacion;

        public int AnnioPublicacion
        {
            get { return annioPublicacion; }
            set { annioPublicacion = value; }
        }
        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private bool enPrestamo;

        public bool EnPrestamo
        {
            get { return enPrestamo; }
            set { enPrestamo = value; }
        }


        public Libro() {
            Init();
        }

        private void Init(){
            Codigo = 0;
            Titulo = string.Empty;
            Autor = string.Empty;
            Editorial = string.Empty;
            AnnioPublicacion = 0;
            Precio = 0;
            EnPrestamo = false;

        }
    }
}
