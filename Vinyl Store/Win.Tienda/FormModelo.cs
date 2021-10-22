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
    public partial class FormModelo : Form
    {
        ModeloBL _modelos;

        public FormModelo()
        {
            InitializeComponent();

            _modelos = new ModeloBL();
            listaModelosBindingSource.DataSource = _modelos.ObtenerModelos();
        }

        private void listaModelosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaModelosBindingSource.EndEdit();
            var modelo = (Modelo)listaModelosBindingSource.Current;

            var resultado = _modelos.GuardarModelo(modelo);

            if (resultado.Exitoso == true)
            {
                listaModelosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Producto Guardado");

            }
            else
                {
                MessageBox.Show(resultado.Mensaje);
                }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _modelos.AgregarModelo();
            listaModelosBindingSource.MoveLast();
            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            

            if (idTextBox1.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox1.Text);
                    Eliminar(id);
                }
                
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _modelos.EliminarModelo(id);

            if (resultado == true)
            {
                listaModelosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el modelo");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}
