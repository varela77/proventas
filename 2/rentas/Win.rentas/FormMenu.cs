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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formLogin = new Formlogin();
            formLogin.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproductos = new formproductos();
            formproductos.MdiParent = this;
            formproductos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRentas = new FormRentas();
            formRentas.MdiParent = this;
            formRentas.Show();
        }

        private void rentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRentas = new FormRentas();
            formRentas.MdiParent = this;
            formRentas.Show();
        }

        private void reporteProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRepoDi = new FormRepoDi();
            formRepoDi.MdiParent = this;
            formRepoDi.Show();
        }

        private void reporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRepoProd = new FormRepoProd();
            formRepoProd.MdiParent = this;
            formRepoProd.Show();
        }

        private void reporteRentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRepoRentas = new FormRepoRentas();
            formRepoRentas.MdiParent = this;
            formRepoRentas.Show();
        }
    }
}
