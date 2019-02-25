using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using capaAccesoDatos;

namespace capaLogicaNegocio
{
    interface ILibro
    {
        bool agregarLibro(Libro nuevoLibro);
        List<Libro> listarTodos();
        bool eliminarLibro(int codigo);
        Libro buscarLibro(int codigo);
        bool modificarLibro(Libro libroModificado);
    }
}
