using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NCategoria
    {
        //Metodo insertar que llama el metodo insertar de la clase DCategoria de la CapaDatos 

        public static string Insertar(string nombre, string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //Metodo Editar que llama el metodo Editar de la clase DCategoria de la CapaDatos 
        public static string Editar(int idcategoria,string nombre, string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }


        //Metodo Eliminar que llama el metodo Eliminar de la clase DCategoria de la CapaDatos 
        public static string Eliminar(int idcategoria)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            return Obj.Editar(Obj);


        }
        //Metodo Mostrar que llama el metodo Mostrar de la clase DCategoria de la CapaDatos 

        public static DataTable Mostrar(int idcategoria)
        {
            return new DCategoria().Mostrar();
            
        }

        public static DataTable BuscarNombre(string texttbuscar)
        {
            DCategoria Obj = new DCategoria();
            Obj.TextoBuscar = texttbuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
