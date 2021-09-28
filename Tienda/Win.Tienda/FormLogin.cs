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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario1;
            string usuario2;
            string contrasena1;
            string contrasena2;

            usuario1 = textBox1.Text;
            usuario2 = textBox1.Text;
            contrasena1 = textBox2.Text;
            contrasena2 = textBox2.Text;


            if (usuario1 == "admin" && contrasena1 == "123")
            {
                this.Close();
            }
            else
            {
                if (usuario2 == "user" && contrasena2 == "456")
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            

            

            
            
        }
    }
}
