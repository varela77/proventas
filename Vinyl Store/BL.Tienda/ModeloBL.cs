using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tienda
{
    public class ArgumentException : SystemException
    {
    }
    public class ModeloBL
    {
        contexto _contexto;
        public BindingList<Modelo> ListaModelos { get; set; } 

        public ModeloBL()
        {
            _contexto = new contexto();
            ListaModelos = new BindingList<Modelo>();

            
        }

        public BindingList<Modelo> ObtenerModelos()
        {
            _contexto.Modelos.Load();

            ListaModelos = _contexto.Modelos.Local.ToBindingList();

            return ListaModelos;
        }

        public Resultado GuardarModelo(Modelo modelo)
        {
            var resultado = Validar(modelo);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarModelo()
        {
            var nuevoModelo = new Modelo();
            ListaModelos.Add(nuevoModelo);
        }

        public bool EliminarModelo(int id)
        {
            foreach (var modelo in ListaModelos)
            {
                if (modelo.Id == id)
                {
                    ListaModelos.Remove(modelo);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Modelo modelo)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(modelo.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripción";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(modelo.Artista) == true)
            {
                resultado.Mensaje = "Ingrese un artista";
                resultado.Exitoso = false;
            }

            if (modelo.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (modelo.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Modelo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public int CategoriaId { get; set; }
        public int tipoId { get; set; }
        public Tipo tipo { get; set; }
        public byte[] foto { get; set; }
        public bool Activo { get; set; }
        public string Artista { get; set; }

    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
