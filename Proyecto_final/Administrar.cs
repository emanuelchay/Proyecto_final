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
    public partial class Administrar : Form
    {
        List<Productos> lproductos =  new List<Productos>();
        public Administrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos temppro = new Productos();
            temppro.Nombre_producto = textBox1.Text;
            temppro.Codigo_producto = Convert.ToInt16(textBox2.Text);
            temppro.Precio_producto = Convert.ToInt16(textBox3.Text);

            lproductos.Add(temppro);


        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = lproductos;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 falumno = new Form1();
            falumno.Visible = true;
            Visible = false;
        }
    }
}
