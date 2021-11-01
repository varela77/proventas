using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLrentas
{
    public class productosBL
    {
        contexto _contexto;
       public BindingList<producto> listaproductos { get; set; }

        public productosBL()
        {
            _contexto = new contexto();
            listaproductos = new BindingList<producto>();

            
        }

        public BindingList<producto> obtenerproductos()
        {
            _contexto.productos.Load();
           
            listaproductos = _contexto.productos.Local.ToBindingList();

        return listaproductos;
         }

        public resultado guardarproducto(producto producto)

        {
            var resultado = validar(producto);
            if (resultado.exitoso == false)
            {
                return resultado;
            }

            if (producto.id == 0)
            {
                producto.id = listaproductos.Max(item => item.id) + 1;
            }
            resultado.exitoso = true;

            return resultado;
        }

        public void agregarproductos()
        {
            var nuevoproducto = new producto();

            listaproductos.Add(nuevoproducto);
        }

        public bool eliminarproducto(int id)
        {

            foreach (var producto in listaproductos)
            {
                if (producto.id == id)
                {
                    listaproductos.Remove(producto);
                    return true;
                }
            }
            {

            }
            return false;
        }

        private resultado validar(producto producto)
        {
            var resultado = new resultado();
            resultado.exitoso = true;

            if (producto.descripcion == "")
            {
                resultado.mensaje = "ingrese una descripcion";
                resultado.exitoso = false;
            }

            if (producto.existencia < 0)
            {
                resultado.mensaje = "la existencia debe ser mayor a cero";
                resultado.exitoso = false;
            }

            if (producto.precio < 0)
            {
                resultado.mensaje = "el precio debe ser mayor a cero";
                resultado.exitoso = false;
            }




            return resultado;
        }
    }

    public class producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int existencia { get; set; }
        public byte[] foto { get; set; }
        public bool activo { get; set; }


    }

    public class resultado
    {
        public bool exitoso { get; set; }
        public string mensaje { get; set; }



    }
   

}
