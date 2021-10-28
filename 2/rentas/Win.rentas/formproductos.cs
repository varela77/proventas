using BLrentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.rentas
{
    public partial class formproductos : Form
    {

        productosBL _productos;


        public formproductos()
        {
            InitializeComponent();

            _productos = new productosBL();
            listaproductosBindingSource.DataSource = _productos.obtenerproductos();
        }

        private void formproductos_Load(object sender, EventArgs e)
        {

        }

        private void listaproductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)

        {
            listaproductosBindingSource.EndEdit();
            var producto = (producto)listaproductosBindingSource.Current;

            var resultado = _productos.guardarproducto(producto);

            if (resultado == true)
            {
                listaproductosBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show("error al guardar producto");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.agregarproductos();
            listaproductosBindingSource.MoveLast();
        }
    }
}
