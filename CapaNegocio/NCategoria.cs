using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;


namespace CapaNegocio
{
    class NCategoria
    {
        //Método insertar que llama al método insertar de la clase DCategoria
        // de la CapaDatos

        public static string Insertar(string nombre, string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //Método editar que llama al método editar de la clase DCategoria
        // de la CapaDatos

        public static string Editar(int idcategoria, string nombre, string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        //Método eliminar que llama al método eliminar de la clase DCategoria
        // de la CapaDatos

        public static string Eliminar(int idcategoria)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            return Obj.Eliminar(Obj);
        }

        //Método mostrar que llama al método mostrar de la clase DCategoria
        // de la CapaDatos

        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar(); 
        }

        //Método buscarnombre que llama al método buscarnombre de la clase DCategoria
        // de la CapaDatos

        public static DataTable BuscarNombre(string textobuscar)
        {
            DCategoria Obj = new DCategoria();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
