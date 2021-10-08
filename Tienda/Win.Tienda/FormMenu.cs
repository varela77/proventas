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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void mantenimiento1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMantenimiento1 = new FormModelo();
            formMantenimiento1.MdiParent = this;
            formMantenimiento1.Show();
        }

        private void mantenimiento2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMantenimiento2 = new FormMantenimiento2();
            formMantenimiento2.MdiParent = this;
            formMantenimiento2.Show();
        }

        private void mantenimiento3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMantenimiento3 = new FormMantenimiento3();
            formMantenimiento3.MdiParent = this;
            formMantenimiento3.Show();
        }

        private void transaccion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTransaccion1 = new FormTransaccion1();
            formTransaccion1.MdiParent = this;
            formTransaccion1.Show();
        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporte1 = new FormReporte1();
            formReporte1.MdiParent = this;
            formReporte1.Show();
        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporte2 = new FormReporte2();
            formReporte2.MdiParent = this;
            formReporte2.Show();
        }

        private void reporte3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporte3 = new FormReporte3();
            formReporte3.MdiParent = this;
            formReporte3.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }
    }
}
