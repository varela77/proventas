using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tienda
{

    public class ModeloBL
    {

        public BindingList<Modelo> ListaModelos { get; set; } = new BindingList<Modelo>();
        public ModeloBL()
        {
            var modelo1 = new Modelo();
            modelo1.Id = 1;
            modelo1.Descipcion = "Vinyl Records Album: My Way";
            modelo1.Artista = "Frank Sinatra";
            modelo1.Precio = 2000;
            modelo1.Existencia = 15;
            modelo1.Activo = true;

            ListaModelos.Add(modelo1);

            var modelo2 = new Modelo();
            modelo2.Id = 2;
            modelo2.Descipcion = "Vinyl Records Album: Let it be";
            modelo2.Artista = "The Beatles";
            modelo2.Precio = 3000;
            modelo2.Existencia = 16;
            modelo2.Activo = true;

            ListaModelos.Add(modelo2);

            var modelo3 = new Modelo();
            modelo3.Id = 3;
            modelo3.Descipcion = "Vinyl Records Album: The Wall";
            modelo3.Artista = "Pink Floy";
            modelo3.Precio = 3500;
            modelo3.Existencia = 25;
            modelo3.Activo = true;

            ListaModelos.Add(modelo3);

        }
        public void guardarModelo(int id, string artista, string descripcion, int existencia, double precio)
        {
            var modelo = new Modelo();
            modelo.Id = id;
            modelo.Descipcion = descripcion;
            modelo.Artista = artista;
            modelo.Precio = precio;
            modelo.Existencia = existencia;
            modelo.Activo = true;

            ListaModelos.Add(modelo);
        }

        public void eliminarRegistro(int id)
        {
            ListaModelos.RemoveAt((id));
        }

        public BindingList<Modelo> ObtenerModelos()
        {
            return ListaModelos;
        }
    }

   

    public class Modelo
    {
        public int Id { get; set; }
        public string Descipcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
        public string Artista { get; set; }
    }
}
