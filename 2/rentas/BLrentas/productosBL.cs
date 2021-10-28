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
        }

    public class producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int existencia { get; set; }
        public bool activo { get; set; }


    }
}
