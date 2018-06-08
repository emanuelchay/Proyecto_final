using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Seguridad : Form
    {
        public Seguridad()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string contraseña = "admin";
            string usuariov = "venta";
            string contraseñav = "1234";
            if (usuario == textBox1.Text && contraseña == textBox2.Text)
            {
                Administrar falumno = new Administrar();
                falumno.Visible = true;
                Visible = false;

            }
        

            else if (usuariov == textBox1.Text && contraseñav == textBox2.Text)
            {
                Ventas falumno = new Ventas();
                falumno.Visible = true;
                Visible = false;
            }
            else
                MessageBox.Show("Datos Incorrectos");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 falumno = new Form1();
            falumno.Visible = true;
            Visible = false;

        }

        private void Seguridad_Load(object sender, EventArgs e)
        {

        }
    }
}
