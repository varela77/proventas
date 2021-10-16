using BL.Tienda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Tienda
{
    public partial class FormMantenimiento2 : Form
    {
        ModeloBL _modelos;
        public FormMantenimiento2()
        {
            InitializeComponent();

            _modelos = new ModeloBL();
            listaModelosMantenimiento.DataSource = _modelos.ObtenerModelos();
        }

        private void listaModelosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(idMante.Text);
            var artista = artistaTextBox.Text;
            var descripcion = descipcionTextBox1.Text;
            var existencia = Int32.Parse(existenciaTextBox1.Text);
            var precio = Convert.ToDouble(precioTextBox1.Text);
            if (artista.Length > 1 && descripcion.Length > 5 && id != null && existencia != null  && precio != null) {
                _modelos.guardarModelo(id, artista, descripcion, existencia, precio);
                listaModelosMantenimiento.DataSource = _modelos.ObtenerModelos();
            }
                
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(idMante.Text);
            _modelos.eliminarRegistro(id);
            listaModelosMantenimiento.DataSource = _modelos.ObtenerModelos();
        }
        
    }
}
