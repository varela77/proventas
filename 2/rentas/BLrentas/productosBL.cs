using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLrentas
{
    public class productosBL
    {
       public BindingList<producto> listaproductos { get; set; }

        public productosBL()
        {
            listaproductos = new BindingList<producto>();

            var producto1 = new producto();
            producto1.id = 1;
            producto1.descripcion = "vinilo 1";
            producto1.precio = 2100;
            producto1.existencia = 13;
            producto1.activo = true;

            listaproductos.Add(producto1);

            var producto2 = new producto();
            producto2.id = 2;
            producto2.descripcion = "vinilo 2";
            producto2.precio = 1400;
            producto2.existencia = 19;
            producto2.activo = true;

            listaproductos.Add(producto2);

            var producto3 = new producto();
            producto3.id = 3;
            producto3.descripcion = "vinilo 3";
            producto3.precio = 800;
            producto3.existencia = 16;
            producto3.activo = true;

            listaproductos.Add(producto3);
        }

        public BindingList<producto> obtenerproductos()
        {
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
        public bool activo { get; set; }


    }

    public class resultado
    {
        public bool exitoso { get; set; }
        public string mensaje { get; set; }



    }

}
