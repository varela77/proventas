using BL.Tienda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tienda
{
    public class TiposBL
    {
        contexto _contexto;

        public BindingList<Tipo> listaTipos { get; set; }

    }

    public TiposBL()
    {
        var _contexto = new contexto();
        var listaTipos = new BindingList<Tipo>();
    }

    public BindingList<Tipo> ObtenerTipos()
    {
        contexto.Tipos.Load();
        object _contexto = null;
        var listaTipos = _contexto.Tipos.Local.ToBindingList();
        return listaTipos;
    }



    public class Tipo
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }

    }
}
