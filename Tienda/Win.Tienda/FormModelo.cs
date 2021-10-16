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

       
    }
}
