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

            if (resultado.exitoso == true)
            {
                listaproductosBindingSource.ResetBindings(false);
                deshabilitarhabilitarbotones(true);

            }
            else
            {
                MessageBox.Show(resultado.mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.agregarproductos();
            listaproductosBindingSource.MoveLast();

            deshabilitarhabilitarbotones(false);
        }

        private void deshabilitarhabilitarbotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButton1.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           

            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                eliminar(id);
                }

            }
        }

        private void eliminar(int id)
        {
            
            var resultado = _productos.eliminarproducto(id);

            if (resultado == true)
            {
                listaproductosBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show("error al eliminar producto");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            deshabilitarhabilitarbotones(true);
            eliminar(0);
        }
    }
}
